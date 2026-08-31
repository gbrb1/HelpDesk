using HelpDesk.Application.Interfaces;
using HelpDesk.Domain.Entities;

namespace HelpDesk.Application.Services;

public class TicketService : ITicketService
{
    private readonly ITicketRepository _ticketRepository;

    public TicketService(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }

    public async Task<Ticket?> GetByIdAsync(int id)
    {
        return await _ticketRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Ticket>> GetAllAsync()
    {
        return await _ticketRepository.GetAllAsync();
    }

    public async Task AddAsync(Ticket ticket)
    {
        await _ticketRepository.AddAsync(ticket);
    }

    public async Task UpdateAsync(Ticket ticket)
    {
        await _ticketRepository.UpdateAsync(ticket);
    }

    public async Task DeleteAsync(Ticket ticket)
    {
        await _ticketRepository.DeleteAsync(ticket);
    }
}