public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value)
    {
    }

    public override void Complete()
    {
        if (!IsCompleted)
        {
            Console.WriteLine($"Congratulations! You have completed the goal: {Name}");
            IsCompleted = true;
            // Add value to the user's score
            // TODO: Implement score tracking logic
        }
    }

    public override string GetProgress()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }
}
