using HelpDesk.Application.Interfaces;
using HelpDesk.Domain.Entities;

namespace HelpDesk.Infrastructure.Repositories;

public class TicketRepository : ITicketRepository
{
    public Task<Ticket?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Ticket>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Ticket ticket)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Ticket ticket)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Ticket ticket)
    {
        throw new NotImplementedException();
    }
}