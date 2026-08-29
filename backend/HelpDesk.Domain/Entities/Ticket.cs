namespace HelpDesk.Domain.Entities;

public class Ticket
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }

    public Ticket(string title, string description)
    {
        Title = title;
        Description = description;
    }
}