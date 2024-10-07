using System;
using TechZone.Shared.Dtos;

namespace TechZone.Core.Abstract;

public interface IProductService
{
    Task<ProductDTO> GetByIdAsync(int id);
    Task<IEnumerable<ProductDTO>> GetAllAsync();
    Task AddAsync(ProductDTO productDto);
    Task UpdateAsync(ProductDTO productDto);
    Task DeleteAsync(int id);
}
