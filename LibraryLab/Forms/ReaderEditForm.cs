using LibraryLab.Entities;
using LibraryLab.Entities.Enums;
using LibraryLab.Repositories;
using LibraryLab.Interfaces;

namespace LibraryLab.Forms;

public partial class ReaderEditForm : Form
{
    private readonly IReaderRepository _repository = null!;
    private readonly Reader? _reader;

    public ReaderEditForm()
    {
        InitializeComponent();
    }

    public ReaderEditForm(IReaderRepository repository, Reader? reader = null) : this()
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _reader = reader;
        Text = reader == null ? "Добавление читателя" : "Редактирование читателя";
        FullNameTextBox.Text = reader?.FullName ?? string.Empty;
        CardNumberTextBox.Text = reader?.CardNumber ?? string.Empty;
        CardExpiresOnPicker.Value = reader?.CardExpiresOn ?? DateTime.Today.AddYears(1);
    }

    private void SaveRecord()
    {
        var reader = Reader.Create(FullNameTextBox.Text, CardNumberTextBox.Text, CardExpiresOnPicker.Value, _reader?.Id);
        if (_reader == null) _repository.Create(reader);
        else _repository.Update(reader);
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
