using HelpDesk.Domain.Enums;

namespace HelpDesk.Domain.Entities;

public class Ticket
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public TicketStatus Status { get; private set; }
    public TicketPriority Priority { get; private set; }
    public int CreatedById { get; private set; }
    public User CreatedBy { get; private set; } = null!;
    public int? AssignedToId { get; private set; }
    public User? AssignedTo { get; private set; }
    public Ticket(string title, string description, int createdById)
    {
        Title = title;
        Description = description;
        CreatedById = createdById;
        Status = TicketStatus.Open;
        Priority = TicketPriority.Medium;
    }
}