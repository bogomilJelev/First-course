using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double rekord = double.Parse(Console.ReadLine());
            double metri = double.Parse(Console.ReadLine());
            double vremeza1m = double.Parse(Console.ReadLine());
            double metri2 = metri * vremeza1m;
            double zabavqne = Math.Floor(metri / 15);
            double zabavqne2 = zabavqne * 12.5;
            double sbor = zabavqne2 + metri2;
            double neededtime = Math.Abs(rekord - sbor);
            if (sbor < rekord)
            {

                Console.WriteLine($"Yes, he succeeded! The new world record is {sbor:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {neededtime:F2} seconds slower.");
            }

        }
    }
}