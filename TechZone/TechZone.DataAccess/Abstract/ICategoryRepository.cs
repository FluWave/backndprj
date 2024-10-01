using System;
using TechZone.Entities.Concrete;

namespace TechZone.DataAccess.Abstract;

public interface ICategoryRepository
{
    Task<Category> GetByIdAsync(int id);
    Task<IEnumerable<Category>> GetAllAsync();
    Task AddAsync(Category category);
    Task UpdateAsync(Category category);
    Task DeleteAsync(int id);
}
