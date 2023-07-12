class EternalGoal : Goal
{
    public EternalGoal() : base("Eternal Goal", 100)
    {
    }

    public override void RecordEvent()
    {
        Points += 100;
    }
}
