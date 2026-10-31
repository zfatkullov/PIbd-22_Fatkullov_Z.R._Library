using LibraryLab.Entities;
using LibraryLab.Entities.Enums;
using LibraryLab.Repositories;
using LibraryLab.Interfaces;

namespace LibraryLab.Forms;

public partial class ReturnCreateForm : Form
{
    private readonly IReturnRecordRepository _returns = null!;

    public ReturnCreateForm()
    {
        InitializeComponent();
    }

    public ReturnCreateForm(IReturnRecordRepository returns, ILoanItemRepository loanItems,
        ILoanRepository loans, IReaderRepository readers, IPublicationRepository publications) : this()
    {
        _returns = returns ?? throw new ArgumentNullException(nameof(returns));
        ArgumentNullException.ThrowIfNull(loanItems);
        ArgumentNullException.ThrowIfNull(loans);
        ArgumentNullException.ThrowIfNull(readers);
        ArgumentNullException.ThrowIfNull(publications);
        FormControls.FillCombo(OutstandingLoanItemCombo, loanItems.GetOutstanding(), item => item.Id, item =>
        {
            var loan = loans.GetById(item.LoanId) ?? throw new InvalidOperationException("Выдача не найдена.");
            var publication = publications.GetById(item.PublicationId) ?? throw new InvalidOperationException("Источник не найден.");
            return $"{readers.GetById(loan.ReaderId)?.FullName ?? "Читатель не найден"} — {publication.Title}, № {publication.InventoryNumber}, до {loan.DueOn:dd.MM.yyyy}";
        });
    }

    private void SaveRecord()
    {
        _returns.Create(ReturnRecord.Create(FormControls.RequiredSelection(OutstandingLoanItemCombo, "Возвращаемый источник")));
    }
    private void SaveButton_Click(object? sender, EventArgs e)
    {
        FormControls.Try(() =>
        {
            SaveRecord();
            DialogResult = DialogResult.OK;
            Close();
        });
    }
}
