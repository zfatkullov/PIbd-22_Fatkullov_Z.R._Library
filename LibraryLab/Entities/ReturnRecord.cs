namespace LibraryLab.Entities;

public sealed class ReturnRecord : Entity
{
    public Guid LoanItemId { get; private set; }
    public DateTime ReturnedOn { get; private set; }

    private ReturnRecord(Guid loanItemId)
    {
        LoanItemId = Validation.Identifier(loanItemId);
        ReturnedOn = DateTime.Today;
    }

    public static ReturnRecord Create(Guid loanItemId)
    {
        return new ReturnRecord(loanItemId);
    }
}
