namespace LibraryLab.Entities;

public sealed class LoanItem : Entity
{
    public Guid LoanId { get; private set; }
    public Guid PublicationId { get; private set; }

    private LoanItem(Guid loanId, Guid publicationId)
    {
        LoanId = Validation.Identifier(loanId);
        PublicationId = Validation.Identifier(publicationId);
    }

    public static LoanItem Create(Guid loanId, Guid publicationId)
    {
        return new LoanItem(loanId, publicationId);
    }
}
