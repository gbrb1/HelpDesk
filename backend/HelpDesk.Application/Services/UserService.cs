using HelpDesk.Application.Interfaces;
using HelpDesk.Domain.Entities;

namespace HelpDesk.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User?> GetByIdAsync(int id)
    {
        return await _userRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _userRepository.GetAllAsync();
    }

    public async Task AddAsync(User user)
    {
        await _userRepository.AddAsync(user);
    }

    public async Task UpdateAsync(User user)
    {
        await _userRepository.UpdateAsync(user);
    }

    public async Task DeleteAsync(User user)
    {
        await _userRepository.DeleteAsync(user);
    }
}