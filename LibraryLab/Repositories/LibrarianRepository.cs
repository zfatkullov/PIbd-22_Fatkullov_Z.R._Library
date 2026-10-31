using LibraryLab.Entities;
using LibraryLab.Entities.Enums;
using LibraryLab.Interfaces;

namespace LibraryLab.Repositories;

public sealed class LibrarianRepository : ILibrarianRepository
{
    public IReadOnlyList<Librarian> GetAll()
    {
        return Array.Empty<Librarian>();
    }

    public Librarian? GetById(Guid id)
    {
        return null;
    }

    public void Create(Librarian entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
    }

    public void Update(Librarian entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
    }

    public void Delete(Guid id)
    {
        Validation.Identifier(id);
    }

    public IReadOnlyList<Librarian> FindBySubject(Subject subject)
    {
        return Array.Empty<Librarian>();
    }
}
