using LibraryLab.Entities;
using LibraryLab.Entities.Enums;
using LibraryLab.Interfaces;

namespace LibraryLab.Repositories;

public sealed class ReturnRecordRepository : IReturnRecordRepository
{
    public IReadOnlyList<ReturnRecord> GetAll()
    {
        return Array.Empty<ReturnRecord>();
    }

    public void Create(ReturnRecord record)
    {
        ArgumentNullException.ThrowIfNull(record);
    }
}
