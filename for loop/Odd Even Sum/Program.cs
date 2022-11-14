using System;
using System.Security.Cryptography;

namespace shizka_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int summodd = 0;
            int summeven = 0;
            for (int i = 0; i < n; i++)
            {
                int currentnum = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    summeven += currentnum;
                }
                else
                {
                    summodd += currentnum;
                }
            }
            double summall = Math.Abs(summodd - summeven);
            if (summodd != summeven)
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {summall} ");
            }
            else
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {summodd}");
            }
        }
    }
}
