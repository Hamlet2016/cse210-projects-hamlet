using System;

public class Program
{
    public static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only Son");

        while (true)
        {
            scripture.Display();

            Console.WriteLine("Press Enter to hide a random word or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            Console.Clear(); // Clear the console

            scripture.HideRandomWord();

            if (scripture.AreAllWordsHidden())
            {
                break;
            }
        }
    }
}
