using HelpDesk.Domain.Entities;

namespace HelpDesk.Application.Interfaces;

public interface IUserService
{
    Task<User?> GetByIdAsync(int id);
    Task<IEnumerable<User>> GetAllAsync();
    Task AddAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(User user);
}