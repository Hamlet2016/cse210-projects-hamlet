using System;

public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CompletedCount { get; set; }

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        TargetCount = targetCount;
        CompletedCount = 0;
    }

    public override void Complete()
    {
        CompletedCount++;
        Console.WriteLine($"You completed an item for the checklist goal: {Name}");

        if (CompletedCount >= TargetCount)
        {
            Console.WriteLine($"Congratulations! You have completed the checklist goal: {Name}");
            IsCompleted = true;
            // Add bonus value to the user's score
            // TODO: Implement score tracking logic
        }
        else
        {
            // Add value to the user's score
            // TODO: Implement score tracking logic
        }
    }

    public override string GetProgress()
    {
        return $"Completed {CompletedCount}/{TargetCount}
