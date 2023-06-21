using System;
using System.Threading;

class BreathingActivity
{
    private int duration;

    public void Run()
    {
        Console.WriteLine("==== Breathing Activity ====");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        Console.Write("Enter the duration of the activity (in seconds): ");
        duration = int.Parse(Console.ReadLine());

        CommonStartingMessage();
        PerformBreathing();
        CommonEndingMessage();
    }

    private void CommonStartingMessage()
    {
        Console.WriteLine("\nGet ready to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    private void PerformBreathing()
    {
        int countdown = duration;

        while (countdown > 0)
        {
            Console.WriteLine(countdown % 2 == 0 ? "Breathe in..." : "Breathe out...");
            countdown--;
            Thread.Sleep(2000); // Pause for 2 seconds
        }
    }

    private void CommonEndingMessage()
    {
        Console.WriteLine("\nGreat job! You have completed the Breathing Activity.");
        Console.WriteLine("Activity duration: " + duration + " seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
    }
}
