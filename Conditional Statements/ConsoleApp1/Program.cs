using System;
using System.Diagnostics.CodeAnalysis;

namespace magazin
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sell = double.Parse(Console.ReadLine());
            bool aaa1 = false;
            double pari = 0;
            if (town != "Plovdiv" && town != "Sofia" && town != "Varna")
            {
                aaa1 = true;
            }
            else if (sell < 0)
            {
                aaa1 = true;

            }
            if (town == "Sofia")

            {
                if (sell >= 0 && sell <= 500)
                {
                    pari = sell * 0.05;
                }
                else if (sell > 500 && sell <= 1000)
                {
                    pari = sell * 0.07;
                }
                else if (sell > 1000 && sell <= 10000)
                {
                    pari = sell * 0.08;
                }
                else if (sell > 10000)
                {
                    pari = sell * 0.12;
                }
            }
            else if (town == "Varna")
            {
                if (sell >= 0 && sell <= 500)
                {
                    pari = sell * 0.045;
                }
                else if (sell > 500 && sell <= 1000)
                {
                    pari = sell * 0.075;
                }
                else if (sell > 1000 && sell <= 10000)
                {
                    pari = sell * 0.1;
                }
                else if (sell > 10000)
                {
                    pari = sell * 0.13;
                }

            }
            else if (town == "Plovdiv")
            {
                if (sell >= 0 && sell <= 500)
                {
                    pari = sell * 0.055;
                }
                else if (sell > 500 && sell <= 1000)
                {
                    pari = sell * 0.08;
                }
                else if (sell > 1000 && sell <= 10000)
                {
                    pari = sell * 0.12;
                }
                else if (sell > 10000)
                {
                    pari = sell * 0.145;
                }
            }
            if (aaa1)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{pari:f2}");
            }

        }
    }
}
