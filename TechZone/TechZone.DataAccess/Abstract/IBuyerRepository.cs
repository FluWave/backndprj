using System;
using TechZone.Entities.Concrete;

namespace TechZone.DataAccess.Abstract;

public interface IBuyerRepository
{
    Task<Buyer> GetByIdAsync(int id);
    Task<IEnumerable<Buyer>> GetAllAsync();
    Task AddAsync(Buyer Buyer);
    Task UpdateAsync(Buyer Buyer);
    Task DeleteAsync(int id);
}
