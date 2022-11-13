using System;
using System.Diagnostics;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = (Console.ReadLine());

            while (true)
            {
                string inpass = (Console.ReadLine());
                if (pass == inpass)
                {
                    Console.WriteLine($"Welcome {name}!");
                    break;
                }
            }
        }
    }
}
