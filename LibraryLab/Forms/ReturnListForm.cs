using LibraryLab.Repositories;
using LibraryLab.Interfaces;
using Unity;

namespace LibraryLab.Forms;

public partial class ReturnListForm : Form
{
    private readonly IReturnRecordRepository _returns = null!;
    private readonly ILoanItemRepository _loanItems = null!;
    private readonly ILoanRepository _loans = null!;
    private readonly IReaderRepository _readers = null!;
    private readonly IPublicationRepository _publications = null!;

    public ReturnListForm()
    {
        InitializeComponent();
    }

    [InjectionConstructor]
    public ReturnListForm(IReturnRecordRepository returns, ILoanItemRepository loanItems, ILoanRepository loans, IReaderRepository readers, IPublicationRepository publications) : this()
    {
        _returns = returns ?? throw new ArgumentNullException(nameof(returns));
        _loanItems = loanItems ?? throw new ArgumentNullException(nameof(loanItems));
        _loans = loans ?? throw new ArgumentNullException(nameof(loans));
        _readers = readers ?? throw new ArgumentNullException(nameof(readers));
        _publications = publications ?? throw new ArgumentNullException(nameof(publications));
    }

    private void ReturnListForm_Shown(object? sender, EventArgs e)
    {
        if (_returns != null)
            FormControls.Try(RefreshReturns);
    }

    private void AddReturnButton_Click(object? sender, EventArgs e)
    {
        FormControls.Try(AddReturn);
    }

    private void AddReturn()
    {
        using var form = new ReturnCreateForm(_returns, _loanItems, _loans, _readers, _publications);
        if (form.ShowDialog(this) == DialogResult.OK)
            RefreshReturns();
    }

    private void RefreshReturns()
    {
        ReturnsGrid.Rows.Clear();
        foreach (var record in _returns.GetAll())
        {
            var item = _loanItems.GetById(record.LoanItemId) ?? throw new InvalidOperationException("Строка выдачи не найдена.");
            var loan = _loans.GetById(item.LoanId) ?? throw new InvalidOperationException("Выдача не найдена.");
            var publication = _publications.GetById(item.PublicationId) ?? throw new InvalidOperationException("Источник не найден.");
            ReturnsGrid.Rows.Add(record.Id, _readers.GetById(loan.ReaderId)?.FullName ?? "Читатель не найден",
                publication.Title, publication.InventoryNumber, record.ReturnedOn.ToString("dd.MM.yyyy"));
        }
    }
}
