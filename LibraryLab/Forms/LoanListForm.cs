using LibraryLab.Repositories;
using LibraryLab.Interfaces;
using Unity;

namespace LibraryLab.Forms;

public partial class LoanListForm : Form
{
    private readonly ILoanRepository _loans = null!;
    private readonly IReaderRepository _readers = null!;
    private readonly ILibrarianRepository _librarians = null!;
    private readonly IPublicationRepository _publications = null!;
    private readonly ILoanItemRepository _loanItems = null!;
    private readonly IReturnRecordRepository _returns = null!;

    public LoanListForm()
    {
        InitializeComponent();
    }

    [InjectionConstructor]
    public LoanListForm(ILoanRepository loans, IReaderRepository readers, ILibrarianRepository librarians, IPublicationRepository publications, ILoanItemRepository loanItems, IReturnRecordRepository returns) : this()
    {
        _loans = loans ?? throw new ArgumentNullException(nameof(loans));
        _readers = readers ?? throw new ArgumentNullException(nameof(readers));
        _librarians = librarians ?? throw new ArgumentNullException(nameof(librarians));
        _publications = publications ?? throw new ArgumentNullException(nameof(publications));
        _loanItems = loanItems ?? throw new ArgumentNullException(nameof(loanItems));
        _returns = returns ?? throw new ArgumentNullException(nameof(returns));
    }

    private void LoanListForm_Shown(object? sender, EventArgs e)
    {
        if (_loans != null)
            FormControls.Try(RefreshLoans);
    }

    private void AddLoanButton_Click(object? sender, EventArgs e)
    {
        FormControls.Try(AddLoan);
    }

    private void OverdueOnlyCheckBox_CheckedChanged(object? sender, EventArgs e)
    {
        if (_loans != null)
            FormControls.Try(RefreshLoans);
    }

    private void LoansGrid_SelectionChanged(object? sender, EventArgs e)
    {
        if (_loans != null)
            FormControls.Try(RefreshItems);
    }

    private void AddLoan()
    {
        using var form = new LoanCreateForm(_loans, _readers, _librarians, _publications, _loanItems);
        if (form.ShowDialog(this) == DialogResult.OK)
            RefreshLoans();
    }

    private void RefreshLoans()
    {
        LoansGrid.Rows.Clear();
        var overdueIds = _loans.GetOverdue(DateTime.Today).Select(loan => loan.Id).ToHashSet();
        var outstandingIds = _loanItems.GetOutstanding().Select(item => item.LoanId).ToHashSet();
        foreach (var loan in _loans.GetAll().Where(loan => !OverdueOnlyCheckBox.Checked || overdueIds.Contains(loan.Id)))
        {
            var state = overdueIds.Contains(loan.Id) ? "Просрочено — должник" : outstandingIds.Contains(loan.Id) ? "На руках" : "Возвращено";
            LoansGrid.Rows.Add(loan.Id, _readers.GetById(loan.ReaderId)?.FullName ?? "Читатель не найден",
                _librarians.GetById(loan.LibrarianId)?.FullName ?? "Библиотекарь не найден", loan.IssuedOn.ToString("dd.MM.yyyy"), loan.DueOn.ToString("dd.MM.yyyy"), state);
        }
        RefreshItems();
    }

    private void RefreshItems()
    {
        LoanItemsGrid.Rows.Clear();
        var loanId = FormControls.SelectedId(LoansGrid);
        if (loanId == null) return;
        var loan = _loans.GetById(loanId.Value) ?? throw new InvalidOperationException("Выдача не найдена.");
        var returns = _returns.GetAll();
        foreach (var item in _loanItems.GetByLoan(loan.Id))
        {
            var publication = _publications.GetById(item.PublicationId) ?? throw new InvalidOperationException("Источник не найден.");
            var returned = returns.FirstOrDefault(record => record.LoanItemId == item.Id);
            var state = returned != null ? "Возвращено" : loan.DueOn < DateTime.Today ? "Просрочено" : "На руках";
            LoanItemsGrid.Rows.Add(item.Id, publication.Title, publication.InventoryNumber, state,
                returned?.ReturnedOn.ToString("dd.MM.yyyy") ?? "—");
        }
    }
}
