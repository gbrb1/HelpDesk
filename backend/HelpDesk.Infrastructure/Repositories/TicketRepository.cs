using HelpDesk.Application.Interfaces;
using HelpDesk.Domain.Entities;
using HelpDesk.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk.Infrastructure.Repositories;

public class TicketRepository : ITicketRepository
{
    private readonly HelpDeskDbContext _context;

    public TicketRepository(HelpDeskDbContext context)
    {
        _context = context;
    }

    public async Task<Ticket?> GetByIdAsync(int id)
    {
        return await _context.Tickets
            .FirstOrDefaultAsync(t => t.Id == id);
    }

    public async Task<IEnumerable<Ticket>> GetAllAsync()
    {
        return await _context.Tickets
            .ToListAsync();
    }

    public async Task AddAsync(Ticket ticket)
    {
        await _context.Tickets.AddAsync(ticket);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Ticket ticket)
    {
        _context.Tickets.Update(ticket);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Ticket ticket)
    {
        _context.Tickets.Remove(ticket);
        await _context.SaveChangesAsync();
    }
}