using LibraryLab.Entities.Enums;

namespace LibraryLab.Entities;

public sealed class Publication : Entity
{
    public string Title { get; private set; }
    public string InventoryNumber { get; private set; }
    public PublicationKind Kind { get; private set; }
    public Subject Subject { get; private set; }

    private Publication(string title, string inventoryNumber, PublicationKind kind, Subject subject, Guid? id) : base(id)
    {
        Title = Validation.Required(title, "Название");
        InventoryNumber = Validation.Required(inventoryNumber, "Инвентарный номер");
        if (!Enum.IsDefined(kind))
            throw new ArgumentException("Выберите вид источника.");
        Kind = kind;
        Subject = Validation.Subjects(subject, true);
    }

    public static Publication Create(string title, string inventoryNumber, PublicationKind kind, Subject subject, Guid? id = null)
    {
        return new Publication(title, inventoryNumber, kind, subject, id);
    }
}
