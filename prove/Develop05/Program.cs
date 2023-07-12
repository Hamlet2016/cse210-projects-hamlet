using System;

class Program
{
    static void Main(string[] args)
    {
        EternalQuestManager questManager = new EternalQuestManager();

        Console.WriteLine("Welcome to the Eternal Quest Program!");

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Show Goals");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Points");
            Console.WriteLine("4. Exit");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    questManager.ShowGoalsAndProgress();
                    break;
                case 2:
                    questManager.RecordEvent();
                    break;
                case 3:
                    questManager.ShowPoints();
                    break;
                case 4:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
