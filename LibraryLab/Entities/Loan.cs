namespace LibraryLab.Entities;

public sealed class Loan : Entity
{
    public Guid ReaderId { get; private set; }
    public Guid LibrarianId { get; private set; }
    public DateTime IssuedOn { get; private set; }
    public DateTime DueOn { get; private set; }

    private Loan(Guid readerId, Guid librarianId, DateTime dueOn)
    {
        ReaderId = Validation.Identifier(readerId);
        LibrarianId = Validation.Identifier(librarianId);
        IssuedOn = DateTime.Today;
        if (dueOn.Date < IssuedOn)
            throw new ArgumentException("Срок возврата не может быть раньше даты выдачи.");
        DueOn = dueOn.Date;
    }

    public static Loan Create(Guid readerId, Guid librarianId, DateTime dueOn)
    {
        return new Loan(readerId, librarianId, dueOn);
    }
}
