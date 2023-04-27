using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int enterNumber;
        //int addingList = 0;
        int average = 0;


        do
        {

            Console.WriteLine("Enter number: ");
            string number = Console.ReadLine();
            enterNumber = int.Parse(number);

            if (enterNumber != 0)
            {
                numbers.Add(enterNumber);
                average++;
            }

            

        } while (enterNumber != 0);

        Console.WriteLine("");

        int add1 = numbers.Sum();

        Console.WriteLine($"The sum is: {add1}");

        float averageFinal = (float)add1/average;
        Console.WriteLine($"The average is: {averageFinal}");

        double MaxInList = numbers.Max();
        Console.WriteLine($"The largest number is: {MaxInList}");



        /*

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        */

    }
}