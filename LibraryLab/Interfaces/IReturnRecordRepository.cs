using LibraryLab.Entities;
using LibraryLab.Entities.Enums;

namespace LibraryLab.Interfaces;

public interface IReturnRecordRepository
{
    IReadOnlyList<ReturnRecord> GetAll();
    void Create(ReturnRecord record);
}
