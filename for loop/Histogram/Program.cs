﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < 200)
                {
                    p1++;
                }
                else if (currentNumber >= 200 && currentNumber <= 399)
                {
                    p2++;
                }
                else if (currentNumber >= 400 && currentNumber <= 599)
                {
                    p3++;
                }
                else if (currentNumber >= 600 && currentNumber <= 799)
                {
                    p4++;
                }
                else if (currentNumber >= 800 && currentNumber <= 1000)
                {
                    p5++;
                }
            }
            double percent1 = p1 / n * 100;
            double percent2 = p2 / n * 100;
            double percent3 = p3 / n * 100;
            double percent4 = p4 / n * 100;
            double percent5 = p5 / n * 100;
            Console.WriteLine($"{percent1:f2}%");
            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");
            Console.WriteLine($"{percent4:f2}%");
            Console.WriteLine($"{percent5:f2}%");
        }
    }
}


