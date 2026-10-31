namespace LibraryLab.Entities;

public sealed class Reader : Entity
{
    public string FullName { get; private set; }
    public string CardNumber { get; private set; }
    public DateTime CardExpiresOn { get; private set; }

    private Reader(string fullName, string cardNumber, DateTime cardExpiresOn, Guid? id) : base(id)
    {
        FullName = Validation.Required(fullName, "ФИО");
        CardNumber = Validation.Required(cardNumber, "Номер билета");
        CardExpiresOn = cardExpiresOn.Date;
    }

    public static Reader Create(string fullName, string cardNumber, DateTime cardExpiresOn, Guid? id = null)
    {
        return new Reader(fullName, cardNumber, cardExpiresOn, id);
    }
}
