using LibraryLab.Entities;
using LibraryLab.Entities.Enums;

namespace LibraryLab.Interfaces;

public interface IPublicationRepository : ICatalogRepository<Publication>
{
    Publication? FindByInventoryNumber(string inventoryNumber);
}
