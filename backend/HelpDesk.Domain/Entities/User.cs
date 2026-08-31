using HelpDesk.Domain.Enums;

namespace HelpDesk.Domain.Entities;

public class User
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public UserRole Role { get; private set; }
    public ICollection<Ticket> CreatedTickets { get; private set; } = new List<Ticket>();
    public ICollection<Ticket> AssignedTickets { get; private set; } = new List<Ticket>();

    public User(string name, string email, UserRole role)
    {
        Name = name;
        Email = email;
        Role = role;
    }
}