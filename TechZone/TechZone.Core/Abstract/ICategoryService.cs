using System;
using TechZone.Shared.Dtos;

namespace TechZone.Core.Abstract;

public interface ICategoryService
{
    Task<CategoryDTO> GetByIdAsync(int id);
    Task<IEnumerable<CategoryDTO>> GetAllAsync();
    Task AddAsync(CategoryDTO categoryDto);
    Task UpdateAsync(CategoryDTO categoryDto);
    Task DeleteAsync(int id);
}
