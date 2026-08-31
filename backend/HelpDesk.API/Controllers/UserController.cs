using HelpDesk.Application.Interfaces;
using HelpDesk.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.API.Controllers;

/// <summary>
/// Controlador responsável pelo gerenciamento de usuários.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    /// <summary>
    /// Retorna todos os usuários.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetAll()
    {
        var users = await _userService.GetAllAsync();

        return Ok(users);
    }

    /// <summary>
    /// Retorna um usuário pelo seu id.
    /// </summary>
    /// <param name="id">Id do usuário que será consultado.</param>
    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetById(int id)
    {
        var user = await _userService.GetByIdAsync(id);

        if (user is null)
            return NotFound();

        return Ok(user);
    }

    /// <summary>
    /// Cria um novo usuário.
    /// </summary>
    /// <param name="user">Dados do usuário que será criado.</param>
    [HttpPost]
    public async Task<IActionResult> Add(User user)
    {
        await _userService.AddAsync(user);

        return CreatedAtAction(
            nameof(GetById),
            new { id = user.Id },
            user);
    }

    /// <summary>
    /// Atualiza um usuário existente.
    /// </summary>
    /// <param name="id">Id do usuário que será atualizado.</param>
    /// <param name="user">Dados atualizados do usuário.</param>
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, User user)
    {
        if (id != user.Id)
            return BadRequest();

        await _userService.UpdateAsync(user);

        return NoContent();
    }

    /// <summary>
    /// Busca um usuário pelo seu id e tenta excluí-lo.
    /// </summary>
    /// <param name="id">Id do usuário que será excluído.</param>
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var user = await _userService.GetByIdAsync(id);

        if (user is null)
            return NotFound();

        await _userService.DeleteAsync(user);

        return NoContent();
    }
}