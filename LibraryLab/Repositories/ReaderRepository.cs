using LibraryLab.Entities;
using LibraryLab.Entities.Enums;
using LibraryLab.Interfaces;

namespace LibraryLab.Repositories;

public sealed class ReaderRepository : IReaderRepository
{
    public IReadOnlyList<Reader> GetAll()
    {
        return Array.Empty<Reader>();
    }

    public Reader? GetById(Guid id)
    {
        return null;
    }

    public void Create(Reader entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
    }

    public void Update(Reader entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
    }

    public void Delete(Guid id)
    {
        Validation.Identifier(id);
    }

    public Reader? FindByCardNumber(string cardNumber)
    {
        return null;
    }
}
