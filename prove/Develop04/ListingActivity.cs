using System;
using System.Threading;

class ListingActivity
{
    private int duration;
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void Run()
    {
        Console.WriteLine("==== Listing Activity ====");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Console.Write("Enter the duration of the activity (in seconds): ");
        duration = int.Parse(Console.ReadLine());

        CommonStartingMessage();
        PerformListing();
        CommonEndingMessage();
    }

    private void CommonStartingMessage()
    {
        Console.WriteLine("\nGet ready to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    private void PerformListing()
    {
        int countdown = duration;

        while (countdown > 0)
        {
            string prompt = prompts[new Random().Next(prompts.Length)];
            Console.WriteLine("\n" + prompt);
            Thread.Sleep(3000); // Pause for 3 seconds

            Console.WriteLine("You have 5 seconds to start listing...");
            Thread.Sleep(5000); // Pause for 5 seconds

            Console.WriteLine("\nEnter your list items (one item per line):");
            int itemCounter = 0;
            string listItem = Console.ReadLine();

            while (!string.IsNullOrEmpty(listItem))
            {
                itemCounter++;
                listItem = Console.ReadLine();
            }

            Console.WriteLine("\nNumber of items listed: " + itemCounter);
            countdown -= (10 + (itemCounter * 2));
        }
    }

    private void CommonEndingMessage()
    {
        Console.WriteLine("\nGreat job! You have completed the Listing Activity.");
        Console.WriteLine("Activity duration: " + duration + " seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
    }
}
