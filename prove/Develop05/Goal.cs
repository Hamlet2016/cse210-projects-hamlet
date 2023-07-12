abstract class Goal
{
    private static int nextId = 1;

    public int Id { get; }
    public string Description { get; }
    public int Points { get; protected set; }
    public bool IsCompleted { get; protected set; }

    public Goal(string description, int points)
    {
        Id = nextId++;
        Description = description;
        Points = points;
        IsCompleted = false;
    }

    public abstract void RecordEvent();

    public virtual string GetCompletionStatus()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }
}
