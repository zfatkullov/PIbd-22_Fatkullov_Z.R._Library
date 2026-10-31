using LibraryLab.Entities.Enums;

namespace LibraryLab.Entities;

internal static class Validation
{
    public static string Required(string? value, string caption)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException($"Заполните поле «{caption}».");
        return value.Trim();
    }

    public static Guid Identifier(Guid value)
    {
        if (value == Guid.Empty)
            throw new ArgumentException("Выберите запись из списка.");
        return value;
    }

    public static Subject Subjects(Subject value, bool single)
    {
        const Subject all = Subject.Fiction | Subject.Science | Subject.History | Subject.Technology;
        if (value == Subject.None || (value & ~all) != 0 ||
            (single && ((int)value & ((int)value - 1)) != 0))
            throw new ArgumentException(single ? "Выберите одну тематику." : "Выберите хотя бы одну тематику.");
        return value;
    }
}
