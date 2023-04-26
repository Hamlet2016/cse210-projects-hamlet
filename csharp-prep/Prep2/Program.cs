using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade?");
        string grade = Console.ReadLine();
        int grade1 = int.Parse(grade);
        string letter = "";

        if (grade1 >= 90)
        {
            letter = "A";

            Console.WriteLine($"You got an {letter}");

        }

        else if (grade1 >= 80)
        {
            letter = "B";
            Console.WriteLine($"You got a {letter}");

        }

        else if (grade1 >= 70)
        {
            letter = "C";
          Console.WriteLine($"You got a {letter}");  
        }

        else if (grade1 >= 60)
        {
            letter = "D";
            Console.WriteLine($"You got a {letter}"); 
        }

        else
        {
            letter = "F";
            Console.WriteLine($"You got an {letter}");
        }

        if (grade1 >= 70)
        {
            Console.WriteLine("Congratulations you have pass the class!");
        }

        else
        {
          Console.WriteLine("Keep on tracking, study more and you will get it!");  
        }


    }
}