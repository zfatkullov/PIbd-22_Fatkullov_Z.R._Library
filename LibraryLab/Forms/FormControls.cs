using LibraryLab.Entities;
using LibraryLab.Entities.Enums;

namespace LibraryLab.Forms;

internal static class FormControls
{
    public static Guid? SelectedId(DataGridView grid)
    {
        return grid.CurrentRow?.Cells[0].Value is Guid id ? id : null;
    }

    public static void Try(Action action)
    {
        try
        {
            action();
        }
        catch (Exception error) when (error is ArgumentException or InvalidOperationException)
        {
            MessageBox.Show(error.Message, "Проверка данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    public static void FillCombo<T>(ComboBox combo, IEnumerable<T> values, Func<T, Guid> id, Func<T, string> caption)
    {
        combo.DisplayMember = "Value";
        combo.ValueMember = "Key";
        combo.DataSource = values.Select(value => new KeyValuePair<Guid, string>(id(value), caption(value))).ToList();
        combo.SelectedIndex = -1;
    }

    public static Guid RequiredSelection(ComboBox combo, string caption)
    {
        if (combo.SelectedValue is not Guid id)
            throw new ArgumentException($"Выберите значение в поле «{caption}».");
        return id;
    }

    public static string SubjectCaption(Subject subjects)
    {
        var names = new List<string>();
        if (subjects.HasFlag(Subject.Fiction)) names.Add("Художественная литература");
        if (subjects.HasFlag(Subject.Science)) names.Add("Наука");
        if (subjects.HasFlag(Subject.History)) names.Add("История");
        if (subjects.HasFlag(Subject.Technology)) names.Add("Техника");
        return string.Join(", ", names);
    }

    public static Subject[] Subjects() => new[] { Subject.Fiction, Subject.Science, Subject.History, Subject.Technology };

    public static string KindCaption(PublicationKind kind) => kind == PublicationKind.Book ? "Книга" : "Журнал";
}
