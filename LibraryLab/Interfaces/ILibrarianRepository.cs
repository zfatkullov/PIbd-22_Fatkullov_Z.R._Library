using LibraryLab.Entities;
using LibraryLab.Entities.Enums;

namespace LibraryLab.Interfaces;

public interface ILibrarianRepository : ICatalogRepository<Librarian>
{
    IReadOnlyList<Librarian> FindBySubject(Subject subject);
}
