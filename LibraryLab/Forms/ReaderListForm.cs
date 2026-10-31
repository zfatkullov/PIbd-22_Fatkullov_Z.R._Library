using LibraryLab.Entities;
using LibraryLab.Entities.Enums;
using LibraryLab.Repositories;
using LibraryLab.Interfaces;
using Unity;

namespace LibraryLab.Forms;

public partial class ReaderListForm : Form
{
    private readonly IReaderRepository _repository = null!;

    public ReaderListForm()
    {
        InitializeComponent();
    }

    [InjectionConstructor]
    public ReaderListForm(IReaderRepository repository) : this()
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    private void ReaderListForm_Shown(object? sender, EventArgs e)
    {
        if (_repository != null)
            FormControls.Try(RefreshRecords);
    }

    private void RefreshRecords()
    {
        RecordsGrid.Rows.Clear();
        foreach (var entity in _repository.GetAll())
            RecordsGrid.Rows.Add(entity.Id, entity.FullName, entity.CardNumber, entity.CardExpiresOn.ToString("dd.MM.yyyy"));
    }

    private void AddRecordButton_Click(object? sender, EventArgs e)
    {
        FormControls.Try(() => OpenEditor(null));
    }

    private void EditRecordButton_Click(object? sender, EventArgs e)
    {
        FormControls.Try(() =>
        {
            var id = FormControls.SelectedId(RecordsGrid)
                ?? throw new InvalidOperationException("Выберите запись для редактирования.");
            var entity = _repository.GetById(id)
                ?? throw new InvalidOperationException("Запись не найдена.");
            OpenEditor(entity);
        });
    }

    private void OpenEditor(Reader? entity)
    {
        using var editor = new ReaderEditForm(_repository, entity);
        if (editor.ShowDialog(this) == DialogResult.OK)
            RefreshRecords();
    }

    private void DeleteRecordButton_Click(object? sender, EventArgs e)
    {
        FormControls.Try(() =>
        {
            var id = FormControls.SelectedId(RecordsGrid)
                ?? throw new InvalidOperationException("Выберите запись для удаления.");
            if (MessageBox.Show(this, "Удалить выбранную запись?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            _repository.Delete(id);
            RefreshRecords();
        });
    }
}
