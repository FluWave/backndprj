using System;
using TechZone.Entities.Concrete;

namespace TechZone.DataAccess.Abstract;

public interface IBagItemRepository
{
    Task<BagItem> GetByIdAsync(int id);
    Task<IEnumerable<BagItem>> GetAllAsync();
    Task AddAsync(BagItem bagItem);
    Task UpdateAsync(BagItem bagItem);
    Task DeleteAsync(int id);
}
