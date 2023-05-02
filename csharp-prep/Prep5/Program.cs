using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        DisplayMessage();

        String userName = PromptUserName();
        //Console.WriteLine ($"\rHello, {userName}!");

        int userNumber = PromptUserNumber();
        //Console.WriteLine ($"{userNumber}");

        int square = SquareNumber(userNumber);
        
        Console.WriteLine ($"\r{userName}, the square of your number is {square}");

        

        
    }

   static void DisplayMessage()
   {
    Console.WriteLine("Welcome to the Program!");
   }


   static string PromptUserName()
   {

    Console.WriteLine("\rPlease enter your name: ");
    string userName = Console.ReadLine();
    return userName;

   }

   static int PromptUserNumber()
   {
    Console.WriteLine("\rPlease enter your favorite number: ");
    int number = int.Parse (Console.ReadLine());
    return number;

   }

   static int SquareNumber(int userNumber)
   {
    int square1 = userNumber * userNumber;
    return square1;

   }

   

}