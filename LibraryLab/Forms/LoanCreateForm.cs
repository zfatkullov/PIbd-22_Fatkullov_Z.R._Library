using LibraryLab.Entities;
using LibraryLab.Entities.Enums;
using LibraryLab.Repositories;
using LibraryLab.Interfaces;

namespace LibraryLab.Forms;

public partial class LoanCreateForm : Form
{
    private readonly ILoanRepository _loans = null!;

    public LoanCreateForm()
    {
        InitializeComponent();
    }

    public LoanCreateForm(ILoanRepository loans, IReaderRepository readers, ILibrarianRepository librarians,
        IPublicationRepository publications, ILoanItemRepository loanItems) : this()
    {
        _loans = loans ?? throw new ArgumentNullException(nameof(loans));
        ArgumentNullException.ThrowIfNull(readers);
        ArgumentNullException.ThrowIfNull(librarians);
        ArgumentNullException.ThrowIfNull(publications);
        ArgumentNullException.ThrowIfNull(loanItems);
        DueOnPicker.Value = DateTime.Today.AddDays(14);
        FormControls.FillCombo(ReaderCombo, readers.GetAll(), reader => reader.Id,
            reader => $"{reader.FullName} — билет {reader.CardNumber}, до {reader.CardExpiresOn:dd.MM.yyyy}");
        FormControls.FillCombo(LibrarianCombo, librarians.GetAll(), librarian => librarian.Id,
            librarian => $"{librarian.FullName} — {FormControls.SubjectCaption(librarian.AllowedSubjects)}");
        var unavailable = loanItems.GetOutstanding().Select(item => item.PublicationId).ToHashSet();
        foreach (var publication in publications.GetAll().Where(publication => !unavailable.Contains(publication.Id)))
            PublicationsSelectionGrid.Rows.Add(publication.Id, false, publication.Title, FormControls.KindCaption(publication.Kind),
                FormControls.SubjectCaption(publication.Subject), publication.InventoryNumber);
    }

    private void SaveRecord()
    {
        PublicationsSelectionGrid.EndEdit();
        var readerId = FormControls.RequiredSelection(ReaderCombo, "Читатель");
        var librarianId = FormControls.RequiredSelection(LibrarianCombo, "Библиотекарь");
        var publicationIds = PublicationsSelectionGrid.Rows.Cast<DataGridViewRow>()
            .Where(row => row.Cells["SelectedColumn"].Value is true)
            .Select(row => (Guid)row.Cells[0].Value).ToArray();
        if (publicationIds.Length == 0)
            throw new ArgumentException("Выберите хотя бы один литературный источник.");
        _loans.Create(Loan.Create(readerId, librarianId, DueOnPicker.Value), publicationIds);
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
