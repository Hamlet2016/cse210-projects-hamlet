using System;
using System.Threading;

class ReflectionActivity
{
    private int duration;
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void Run()
    {
        Console.WriteLine("==== Reflection Activity ====");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Console.Write("Enter the duration of the activity (in seconds): ");
        duration = int.Parse(Console.ReadLine());

        CommonStartingMessage();
        PerformReflection();
        CommonEndingMessage();
    }

    private void CommonStartingMessage()
    {
        Console.WriteLine("\nGet ready to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    private void PerformReflection()
    {
        int countdown = duration;

        while (countdown > 0)
        {
            string prompt = prompts[new Random().Next(prompts.Length)];
            Console.WriteLine("\n" + prompt);
            Thread.Sleep(3000); // Pause for 3 seconds

            Console.WriteLine("Reflect on the following questions:");

            foreach (string question in questions)
            {
                Console.WriteLine("\n" + question);
                Thread.Sleep(3000); // Pause for 3 seconds
                Console.WriteLine("Reflecting...");
                Thread.Sleep(5000); // Pause for 5 seconds
            }

            countdown -= (questions.Length * 8);
        }
    }

    private void CommonEndingMessage()
    {
        Console.WriteLine("\nGreat job! You have completed the Reflection Activity.");
        Console.WriteLine("Activity duration: " + duration + " seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
    }
}
