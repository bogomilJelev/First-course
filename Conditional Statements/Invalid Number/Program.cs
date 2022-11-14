using System;
using System.Diagnostics.CodeAnalysis;

namespace magazin
{
    class Program
    {
        static void Main(string[] args)
        {

            int op = int.Parse(Console.ReadLine());
            if (op >= 100 && op <= 200 || op == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
