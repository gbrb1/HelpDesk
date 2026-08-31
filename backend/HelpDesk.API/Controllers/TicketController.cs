using HelpDesk.Application.Interfaces;
using HelpDesk.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.API.Controllers;

/// <summary>
/// Controlador responsável pelo gerenciamento de tickets.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class TicketController : ControllerBase
{
    private readonly ITicketService _ticketService;

    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    /// <summary>
    /// Retorna todos os tickets registrados em banco.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Ticket>>> GetAll()
    {
        var tickets = await _ticketService.GetAllAsync();

        return Ok(tickets);
    }

    /// <summary>
    /// Retorna um ticket pelo seu id.
    /// </summary>
    /// <param name="id">Id do ticket que será consultado.</param>
    [HttpGet("{id}")]
    public async Task<ActionResult<Ticket>> GetById(int id)
    {
        var ticket = await _ticketService.GetByIdAsync(id);

        if (ticket is null)
            return NotFound();

        return Ok(ticket);
    }

    /// <summary>
    /// Cria um novo ticket.
    /// </summary>
    /// <param name="ticket">Dados do ticket que será criado.</param>
    [HttpPost]
    public async Task<IActionResult> Add(Ticket ticket)
    {
        await _ticketService.AddAsync(ticket);

        return CreatedAtAction(
            nameof(GetById),
            new { id = ticket.Id },
            ticket);
    }

    /// <summary>
    /// Atualiza um ticket existente.
    /// </summary>
    /// <param name="id">Id do ticket que será atualizado.</param>
    /// <param name="ticket">Dados atualizados do ticket.</param>
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Ticket ticket)
    {
        if (id != ticket.Id)
            return BadRequest();

        await _ticketService.UpdateAsync(ticket);

        return NoContent();
    }

    /// <summary>
    /// Busca um ticket pelo seu id e tenta excluí-lo.
    /// </summary>
    /// <param name="id">Id do ticket que será excluído.</param>
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