using System;
using TechZone.Entities.Concrete;

namespace TechZone.DataAccess.Abstract;

public interface IBagRepository
{
    Task<Bag> GetByIdAsync(int id);
    Task<IEnumerable<Bag>> GetAllAsync();
    Task AddAsync(Bag bag);
    Task UpdateAsync(Bag bag);
    Task DeleteAsync(int id);
}
