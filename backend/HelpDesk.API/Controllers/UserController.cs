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

    /// <summary>
    /// Inicializa uma nova instância do controlador de usuários.
    /// </summary>
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
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, User user)
    {
        if (id != user.Id)
            return BadRequest();

        await _userService.UpdateAsync(user);

        return NoContent();
    }

    /// <summary>
    /// Busca um usuário pelo seu id e tenta exclui-lo.
    /// </summary>
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