using LibraryLab.Entities;
using LibraryLab.Entities.Enums;

namespace LibraryLab.Interfaces;

public interface ICatalogRepository<T> where T : Entity
{
    IReadOnlyList<T> GetAll();
    T? GetById(Guid id);
    void Create(T entity);
    void Update(T entity);
    void Delete(Guid id);
}
