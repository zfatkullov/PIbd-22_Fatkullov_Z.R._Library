using LibraryLab.Entities;
using LibraryLab.Entities.Enums;
using LibraryLab.Interfaces;

namespace LibraryLab.Repositories;

public sealed class LoanItemRepository : ILoanItemRepository
{
    public IReadOnlyList<LoanItem> GetByLoan(Guid loanId)
    {
        return Array.Empty<LoanItem>();
    }

    public IReadOnlyList<LoanItem> GetOutstanding()
    {
        return Array.Empty<LoanItem>();
    }

    public LoanItem? GetById(Guid id)
    {
        return null;
    }
}
