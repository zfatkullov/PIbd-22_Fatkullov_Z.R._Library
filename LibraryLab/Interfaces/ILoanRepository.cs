using LibraryLab.Entities;
using LibraryLab.Entities.Enums;

namespace LibraryLab.Interfaces;

public interface ILoanRepository
{
    IReadOnlyList<Loan> GetAll();
    Loan? GetById(Guid id);
    void Create(Loan loan, IEnumerable<Guid> publicationIds);
    IReadOnlyList<Loan> GetOverdue(DateTime asOf);
}
