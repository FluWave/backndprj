using System;
using TechZone.Shared.Dtos;

namespace TechZone.Core.Abstract;

public interface IBagService
{
    Task<BagDTO> GetByIdAsync(int id);
    Task<IEnumerable<BagDTO>> GetAllAsync();
    Task AddAsync(BagDTO bagDto);
    Task UpdateAsync(BagDTO bagDto);
    Task DeleteAsync(int id);
}
