using LibraryLab.Entities;
using LibraryLab.Entities.Enums;
using LibraryLab.Interfaces;

namespace LibraryLab.Repositories;

public sealed class LoanRepository : ILoanRepository
{
    public IReadOnlyList<Loan> GetAll()
    {
        return Array.Empty<Loan>();
    }

    public Loan? GetById(Guid id)
    {
        return null;
    }

    public void Create(Loan loan, IEnumerable<Guid> publicationIds)
    {
        ArgumentNullException.ThrowIfNull(loan);
        ArgumentNullException.ThrowIfNull(publicationIds);
    }

    public IReadOnlyList<Loan> GetOverdue(DateTime asOf)
    {
        return Array.Empty<Loan>();
    }
}
