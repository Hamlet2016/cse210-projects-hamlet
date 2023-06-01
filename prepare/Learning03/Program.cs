using System;

namespace FractionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numerator:");
            int numerator = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the denominator:");
            int denominator = int.Parse(Console.ReadLine());

            Fraction fraction = new Fraction(numerator, denominator);

            Console.WriteLine("Fraction: " + fraction.GetFractionString());
            Console.WriteLine("Decimal value: " + fraction.GetDecimalValue());
        }
    }
}
