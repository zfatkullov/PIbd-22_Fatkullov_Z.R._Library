using LibraryLab.Entities;
using LibraryLab.Entities.Enums;

namespace LibraryLab.Interfaces;

public interface ILoanItemRepository
{
    IReadOnlyList<LoanItem> GetByLoan(Guid loanId);
    IReadOnlyList<LoanItem> GetOutstanding();
    LoanItem? GetById(Guid id);
}
