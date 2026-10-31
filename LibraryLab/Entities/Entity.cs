namespace LibraryLab.Entities;

public abstract class Entity
{
    public Guid Id { get; private set; }

    protected Entity(Guid? id = null)
    {
        Id = id ?? Guid.NewGuid();
        if (Id == Guid.Empty)
            throw new ArgumentException("Идентификатор не может быть пустым.");
    }
}
