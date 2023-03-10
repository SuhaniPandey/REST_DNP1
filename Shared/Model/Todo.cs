namespace Shared;

public class Todo
{
    public int Id { get; set; }
    public User Owner { get; set; }
    public string Title { get; set; }
    public bool isCompleted { get; set; }

    public Todo( User owner, string title)
    {
        Owner = owner;
        Title = title;
    }
}
