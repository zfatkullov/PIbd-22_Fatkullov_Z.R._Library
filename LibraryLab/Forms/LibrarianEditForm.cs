using LibraryLab.Entities;
using LibraryLab.Entities.Enums;
using LibraryLab.Repositories;
using LibraryLab.Interfaces;

namespace LibraryLab.Forms;

public partial class LibrarianEditForm : Form
{
    private readonly ILibrarianRepository _repository = null!;
    private readonly Librarian? _librarian;
    private readonly Subject[] _subjectValues = FormControls.Subjects();

    public LibrarianEditForm()
    {
        InitializeComponent();
    }

    public LibrarianEditForm(ILibrarianRepository repository, Librarian? librarian = null) : this()
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _librarian = librarian;
        Text = librarian == null ? "Добавление библиотекаря" : "Редактирование библиотекаря";
        FullNameTextBox.Text = librarian?.FullName ?? string.Empty;
        for (int index = 0; index < _subjectValues.Length; index++)
            AllowedSubjectsList.SetItemChecked(index, librarian?.AllowedSubjects.HasFlag(_subjectValues[index]) ?? false);
    }

    private void SaveRecord()
    {
        var subjects = Subject.None;
        foreach (int index in AllowedSubjectsList.CheckedIndices)
            subjects |= _subjectValues[index];
        var librarian = Librarian.Create(FullNameTextBox.Text, subjects, _librarian?.Id);
        if (_librarian == null) _repository.Create(librarian);
        else _repository.Update(librarian);
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
