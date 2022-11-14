using System;
using System.Diagnostics.CodeAnalysis;

namespace Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            string ask = "closed";

            if (number >= 10 && number <= 18)
            {
                if (day == "Sunday")
                {
                    ask = "closed";

                }
                else
                {
                    ask = "open";
                }

            }
            Console.WriteLine(ask);



        }
    }
}
