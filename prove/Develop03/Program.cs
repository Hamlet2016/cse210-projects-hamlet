using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a Scripture object with reference and text
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
                Console.WriteLine("All words are hidden. Exiting...");
                break;
            }
        }
    }
    // Exceeding Requirement: The program allows the user to repeatedly hide random words in the scripture by pressing Enter, until all words are hidden or the user types 'quit'.
    // Exceeding Requirement: The program keeps track of the number of hidden words and displays the remaining count after hiding each word.
    // Exceeding Requirement: The program provides a message when all words are hidden and exits gracefully.
}
