using HelpDesk.Domain.Entities;

namespace HelpDesk.Application.Interfaces;

public interface ITicketService
{
    Task<Ticket?> GetByIdAsync(int id);

    Task<IEnumerable<Ticket>> GetAllAsync();

    Task AddAsync(Ticket ticket);

    Task UpdateAsync(Ticket ticket);

    Task DeleteAsync(Ticket ticket);
}