using System;
using System.Diagnostics.CodeAnalysis;

namespace magazin
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            double income = 0;
            if (type == "Premiere")
            {
                income = n * r * 12;
            }
            else if (type == "Normal")
            {
                income = n * r * 7.50;
            }
            else if (type == "Discount")
            {
                income = n * r * 5;
            }
            Console.WriteLine($"{income:f2}");
        }
    }
}
