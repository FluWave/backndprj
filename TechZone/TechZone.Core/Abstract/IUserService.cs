using System;
using TechZone.Shared.Dtos;

namespace TechZone.Core.Abstract;

public interface IUserService
{
    Task<UserDTO> GetByIdAsync(int id);
    Task<IEnumerable<UserDTO>> GetAllAsync();
    Task AddAsync(UserDTO userDto);
    Task UpdateAsync(UserDTO userDto);
    Task DeleteAsync(int id);
}
