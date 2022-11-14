using System;
using System.Diagnostics.CodeAnalysis;

namespace magazin
{
    class Program
    {
        static void Main(string[] args)
        {

            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double banana = 0;
            double apple = 0;
            double orange = 0;
            double grapefruit = 0;
            double kiwi = 0;
            double pineapple = 0;
            double grapes = 0;
            string ask = "error";
            bool sak = false;
            bool sak2 = false;
            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                banana = 2.50;
                apple = 1.20;
                orange = 0.85;
                grapefruit = 1.45;
                kiwi = 2.70;
                pineapple = 5.50;
                grapes = 3.85;
                if (fruit == "banana")
                {
                    banana *= count;
                    Console.WriteLine($"{banana:f2}");
                }
                else if (fruit == "apple")
                {
                    apple *= count;
                    Console.WriteLine($"{apple:f2}");
                }
                else if (fruit == "orange")
                {
                    orange *= count;
                    Console.WriteLine($"{orange:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    grapefruit *= count;
                    Console.WriteLine($"{grapefruit:f2}");
                }
                else if (fruit == "kiwi")
                {
                    kiwi *= count;
                    Console.WriteLine($"{kiwi:f2}");
                }
                else if (fruit == "pineapple")
                {
                    pineapple *= count;
                    Console.WriteLine($"{pineapple:f2}");
                }
                else if (fruit == "grapes")
                {
                    grapes *= count;
                    Console.WriteLine($"{grapes:f2}");
                }
                else
                {
                    sak = true;
                }
            }





            else if (day == "Saturday" || day == "Sunday")
            {
                banana = 2.70;
                apple = 1.25;
                orange = 0.90;
                grapefruit = 1.60;
                kiwi = 3.00;
                pineapple = 5.60;
                grapes = 4.20;
                if (fruit == "banana")
                {
                    banana *= count;
                    Console.WriteLine($"{banana:f2}");
                }
                else if (fruit == "apple")
                {
                    apple *= count;
                    Console.WriteLine($"{apple:f2}");
                }
                else if (fruit == "orange")
                {
                    orange *= count;
                    Console.WriteLine($"{orange:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    grapefruit *= count;
                    Console.WriteLine($"{grapefruit:f2}");
                }
                else if (fruit == "kiwi")
                {
                    kiwi *= count;
                    Console.WriteLine($"{kiwi:f2}");
                }
                else if (fruit == "pineapple")
                {
                    pineapple *= count;
                    Console.WriteLine($"{pineapple:f2}");
                }
                else if (fruit == "grapes")
                {
                    grapes *= count;
                    Console.WriteLine($"{grapes:f2}");
                }
                else
                {
                    sak = true;
                }


            }
            else
            {
                sak2 = true;
            }
            if (sak)
            {
                Console.WriteLine(ask);
            }
            else if (sak2)
            {
                Console.WriteLine(ask);
            }




        }
    }
}
