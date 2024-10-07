using System;
using TechZone.Shared.Dtos;

namespace TechZone.Core.Abstract;

public interface IBuyerService
{
    Task<BuyerDTO> GetByIdAsync(int id);
    Task<IEnumerable<BuyerDTO>> GetAllAsync();
    Task AddAsync(BuyerDTO buyerDto);
    Task UpdateAsync(BuyerDTO buyerDto);
    Task DeleteAsync(int id);
}
