using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

namespace magazin
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            double all = 0;

            if (n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (oper == "-")
            {
                all = n1 - n2;
                if (all % 2 == 0)
                {
                    Console.WriteLine($"{n1} - {n2} = {all} - even");
                }
                else if (all % 3 == 0)
                {
                    Console.WriteLine($"{n1} - {n2} = {all} - odd");
                }

            }
            else if (oper == "/")
            {
                all = n1 / n2;

                Console.WriteLine($"{n1} / {n2} = {all:f2} ");

            }
            else if (oper == "*")
            {
                all = n1 * n2;

                if (all % 2 == 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {all} - even ");
                }
                else if (all % 3 == 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {all} - odd ");
                }
            }
            else if (oper == "%")
            {
                all = n1 % n2;

                Console.WriteLine($"{n1} % {n2} = {all} ");

            }
            else if (oper == "+")
            {
                all = n1 + n2;
                if (all % 2 == 0)
                {
                    Console.WriteLine($"{n1} + {n2} = {all} - even");
                }
                else if (all % 3 == 0)
                {
                    Console.WriteLine($"{n1} + {n2} = {all} - odd");
                }
            }
        }
    }
}
