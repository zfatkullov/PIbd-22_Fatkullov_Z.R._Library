using LibraryLab.Entities;
using LibraryLab.Entities.Enums;
using LibraryLab.Interfaces;

namespace LibraryLab.Repositories;

public sealed class PublicationRepository : IPublicationRepository
{
    public IReadOnlyList<Publication> GetAll()
    {
        return Array.Empty<Publication>();
    }

    public Publication? GetById(Guid id)
    {
        return null;
    }

    public void Create(Publication entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
    }

    public void Update(Publication entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
    }

    public void Delete(Guid id)
    {
        Validation.Identifier(id);
    }

    public Publication? FindByInventoryNumber(string inventoryNumber)
    {
        return null;
    }
}
