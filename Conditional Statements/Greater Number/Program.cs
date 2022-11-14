using System;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            if (number < number2)
            {
                Console.WriteLine($"{number2}");
            }
            else
            {
                Console.WriteLine($"{number}");
            }

        }
    }
}