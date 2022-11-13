using System;
using System.Diagnostics;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int summ = 0;
            while (true)
            {
                int curent = int.Parse(Console.ReadLine());
                summ += curent;
                if (summ >= number)
                {
                    Console.WriteLine(summ);
                    break;
                }

            }
        }
    }
}
