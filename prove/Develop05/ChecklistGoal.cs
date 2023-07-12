class ChecklistGoal : Goal
{
    private int completedCount;
    private int requiredCount;
    private int bonusPoints;

    public ChecklistGoal() : base("Checklist Goal", 50)
    {
        completedCount = 0;
        requiredCount = 10;
        bonusPoints = 500;
    }

    public override void RecordEvent()
    {
        completedCount++;

        if (completedCount == requiredCount)
        {
            IsCompleted = true;
            Points += bonusPoints;
        }
    }

    public override string GetCompletionStatus()
    {
        return IsCompleted ? $"Completed {completedCount}/{requiredCount} times" : base.GetCompletionStatus();
    }
}
