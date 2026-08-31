using HelpDesk.Application.Interfaces;
using HelpDesk.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TicketController : ControllerBase
{
    private readonly ITicketService _ticketService;

    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Ticket>>> GetAll()
    {
        var tickets = await _ticketService.GetAllAsync();

        return Ok(tickets);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Ticket>> GetById(int id)
    {
        var ticket = await _ticketService.GetByIdAsync(id);

        if (ticket is null)
            return NotFound();

        return Ok(ticket);
    }

    [HttpPost]
    public async Task<IActionResult> Add(Ticket ticket)
    {
        await _ticketService.AddAsync(ticket);

        return CreatedAtAction(
            nameof(GetById),
            new { id = ticket.Id },
            ticket);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Ticket ticket)
    {
        if (id != ticket.Id)
            return BadRequest();

        await _ticketService.UpdateAsync(ticket);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var ticket = await _ticketService.GetByIdAsync(id);

        if (ticket is null)
            return NotFound();

        await _ticketService.DeleteAsync(ticket);

        return NoContent();
    }
}