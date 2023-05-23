using System;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    private Journal journal;
    private List<string> prompts;

    public Program()
    {
        journal = new Journal();
        prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public void DisplayMenu()
    {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
    }

    public void Run()
    {
        while (true)
        {
            DisplayMenu();
            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    public void WriteNewEntry()
    {
        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.Write(prompt + " ");
        string response = Console.ReadLine();
        Entry entry = new Entry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Today
        };
        journal.AddEntry(entry);
    }

    public void DisplayJournal()
    {
        journal.DisplayJournal();
    }

    public void SaveJournal()
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();
        journal.SaveJournal(filename);
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadJournal()
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();
        journal.LoadJournal(filename);
        Console.WriteLine("Journal loaded successfully.");
    }
}
