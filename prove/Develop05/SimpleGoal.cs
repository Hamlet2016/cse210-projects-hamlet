class SimpleGoal : Goal
{
    public SimpleGoal() : base("Simple Goal", 1000)
    {
    }

    public override void RecordEvent()
    {
        IsCompleted = true;
    }
}
