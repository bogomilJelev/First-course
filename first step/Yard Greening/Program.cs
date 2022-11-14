using System;

namespace asda
{
    class Program
    {
        static void Main(string[] args)
        {

            double metri = double.Parse(Console.ReadLine());
            double metri2 = metri * 7.61;
            double discount = 0.18 * metri2;
            double total = metri2 - discount;
            Console.WriteLine($"The final price is: {total} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");


        }
    }
}
