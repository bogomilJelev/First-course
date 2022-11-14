using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

namespace magazin
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double prize = 0;

            if (season == "Spring")
            {
                prize = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                prize = 4200;
            }
            else if (season == "Winter")
            {
                prize = 2600;
            }
            if (count <= 6)
            {
                prize *= 0.9;
            }
            else if (count >= 7 && count <= 11)
            {
                prize *= 0.85;
            }
            else if (count > 12)
            {
                prize *= 0.75;
            }
            if (count % 2 == 0 && season != "Autumn")
            {
                prize *= 0.95;
            }
            double all = Math.Abs(budget - prize);
            if (budget >= prize)
            {
                Console.WriteLine($"Yes! You have {all:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {all:f2} leva.");
            }



        }
    }
}
