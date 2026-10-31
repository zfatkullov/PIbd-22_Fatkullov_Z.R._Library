using LibraryLab.Entities;
using LibraryLab.Entities.Enums;

namespace LibraryLab.Interfaces;

public interface IReaderRepository : ICatalogRepository<Reader>
{
    Reader? FindByCardNumber(string cardNumber);
}
