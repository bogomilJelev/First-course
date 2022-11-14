using System;

namespace nestleloops
{
    class Program
    {
        static void Main(string[] args)
        {
            double summ = 0;

            while (true)
            {
                string comand = Console.ReadLine();
                if (comand == "End")
                {
                    break;
                }
                double minbudget = double.Parse(Console.ReadLine());
                while (true)
                {
                    double curentnum = double.Parse(Console.ReadLine());
                    summ += curentnum;
                    if (summ >= minbudget)
                    {
                        Console.WriteLine($"Going to {comand}!");
                        summ = 0;
                        break;
                    }
                }

            }

        }

    }
}
