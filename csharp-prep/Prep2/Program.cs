using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade?");
        string grade = Console.ReadLine();
        int grade1 = int.Parse(grade);

        if (grade1 >= 90)
        {

            Console.WriteLine("You got an A");

        }

        else if (grade1 >= 80)
        {
            Console.WriteLine("You got a B");

        }

        else if (grade1 >= 70)
        {
          Console.WriteLine("You got a C");  
        }

        else if (grade1 >= 60)
        {
            Console.WriteLine("You got a D"); 
        }

        else
        {
            Console.WriteLine("You got an F");
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