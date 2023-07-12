class EternalQuestManager
{
    private List<Goal> goals;
    private int totalPoints;

    public EternalQuestManager()
    {
        goals = new List<Goal>();
        totalPoints = 0;

        InitializeGoals();
    }

    private void InitializeGoals()
    {
        goals.Add(new SimpleGoal());
        goals.Add(new EternalGoal());
        goals.Add(new ChecklistGoal());
    }

    public void ShowGoalsAndProgress()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"Goal ID: {goal.Id}\nDescription: {goal.Description}\nCompletion: {goal.GetCompletionStatus()}\n");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter the goal ID to record an event:");
        int goalId = Convert.ToInt32(Console.ReadLine());

        Goal goal = goals.Find(g => g.Id == goalId);

        if (goal != null)
        {
            goal.RecordEvent();
            totalPoints += goal.Points;
            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal ID. Please try again.");
        }
    }

    public void ShowPoints()
    {
        Console.WriteLine($"Total Points: {totalPoints}");
    }
}
