using System;

namespace trip2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seasson = Console.ReadLine();
            double budgetpercen = 0;
            string where = "";
            string hoterorcamp = "";
            if (budget <= 100)
            {
                if (seasson == "summer")
                {
                    budget *= 0.3;
                    hoterorcamp = "Camp";
                }
                else if (seasson == "winter")
                {
                    budget *= 0.7;
                    hoterorcamp = "Hotel";
                }
                where = ("Somewhere in Bulgaria");
            }
            if (budget <= 1000 && budget >= 100)
            {
                if (seasson == "summer")
                {
                    budget *= 0.4;
                    hoterorcamp = "Camp";
                }
                else if (seasson == "winter")
                {
                    budget *= 0.8;
                    hoterorcamp = "Hotel";
                }
                where = ("Somewhere in Balkans");
            }
            if (budget > 1000)
            {
                if (seasson == "summer")
                {
                    budget *= 0.9;
                    hoterorcamp = "Hotel";
                }
                else if (seasson == "winter")
                {
                    budget *= 0.9;
                    hoterorcamp = "Hotel";
                }
                where = ("Somewhere in Europe");
            }
            Console.WriteLine($"{where}");
            Console.WriteLine($"{hoterorcamp} - {budget:f2}");
        }
    }
}
