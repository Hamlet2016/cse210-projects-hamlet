using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        // Create different types of goals
        SimpleGoal marathonGoal = new SimpleGoal("Run a marathon", 1000);
        EternalGoal scripturesGoal = new EternalGoal("Read scriptures", 100);
        ChecklistGoal templeGoal = new ChecklistGoal("Attend the temple", 50, 10);

        // Add goals to the list
        goals.Add(marathonGoal);
        goals.Add(scripturesGoal);
        goals.Add(templeGoal);

        // Record an event (accomplished goal) for each goal
        foreach (Goal goal in goals)
        {
            goal.Complete();
        }

        // Display the list of goals and their progress
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{goal.GetProgress()} {goal.Name}");
        }

        Console.ReadLine();
    }
}
