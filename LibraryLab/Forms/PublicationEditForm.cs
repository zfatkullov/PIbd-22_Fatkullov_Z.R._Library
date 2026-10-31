using LibraryLab.Entities;
using LibraryLab.Entities.Enums;
using LibraryLab.Repositories;
using LibraryLab.Interfaces;

namespace LibraryLab.Forms;

public partial class PublicationEditForm : Form
{
    private readonly IPublicationRepository _repository = null!;
    private readonly Publication? _publication;
    private readonly Subject[] _subjectValues = FormControls.Subjects();

    public PublicationEditForm()
    {
        InitializeComponent();
    }

    public PublicationEditForm(IPublicationRepository repository, Publication? publication = null) : this()
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _publication = publication;
        Text = publication == null ? "Добавление источника" : "Редактирование источника";
        PublicationTitleTextBox.Text = publication?.Title ?? string.Empty;
        InventoryNumberTextBox.Text = publication?.InventoryNumber ?? string.Empty;
        PublicationKindCombo.SelectedIndex = publication == null ? -1 : (int)publication.Kind - 1;
        PublicationSubjectCombo.SelectedIndex = publication == null ? -1 : Array.IndexOf(_subjectValues, publication.Subject);
    }

    private void SaveRecord()
    {
        if (PublicationKindCombo.SelectedIndex < 0 || PublicationSubjectCombo.SelectedIndex < 0)
            throw new ArgumentException("Выберите вид и тематику источника.");
        var publication = Publication.Create(PublicationTitleTextBox.Text, InventoryNumberTextBox.Text,
            (PublicationKind)(PublicationKindCombo.SelectedIndex + 1), _subjectValues[PublicationSubjectCombo.SelectedIndex], _publication?.Id);
        if (_publication == null) _repository.Create(publication);
        else _repository.Update(publication);
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
