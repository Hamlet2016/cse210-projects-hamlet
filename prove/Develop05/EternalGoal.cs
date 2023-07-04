public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value)
    {
    }

    public override void Complete()
    {
        Console.WriteLine($"You recorded progress for the eternal goal: {Name}");
        // Add value to the user's score
        // TODO: Implement score tracking logic
    }

    public override string GetProgress()
    {
        return "[ ]";
    }
}
