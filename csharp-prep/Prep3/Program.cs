using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("What is your magic number? ");
        string guessing = Console.ReadLine();
        int guessing1 = int.Parse(guessing);
        Console.WriteLine($"Your magic number is {guessing1} ");

        int guessing_client;

        do
        {
         Console.WriteLine("What is your guess? ");
         string guessing2 = Console.ReadLine();
         guessing_client = int.Parse(guessing2);

        

         if (guessing_client > guessing1)
         {
             Console.WriteLine("Lower");
         }
         else if (guessing_client < guessing1)
         {
            Console.WriteLine("Higher"); 
         }
         else
         {
           Console.WriteLine("You guessed it!");   
         }
        } while (guessing_client != guessing1);


    }
}