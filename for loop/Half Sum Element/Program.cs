using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

namespace magazin
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int summ = 0;

            for (int i = 0; i < a; i++)
            {
                int num = int.Parse(Console.ReadLine());
                summ += num;
                if (num > max)
                {
                    max = num;
                }
            }
            int summ2 = summ - max;
            if (summ2 == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = Math.Abs(max - summ2);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
