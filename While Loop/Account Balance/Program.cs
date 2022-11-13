using System;
using System.Diagnostics;

namespace while_loop
{
    class Program
    {
        static void Main()
        {
            double total = 0;

            while (true)
            {
                string word = Console.ReadLine();
                if (word == "NoMoreMoney")
                {
                    break;
                }
                double word1 = double.Parse(word);
                if (word1 < 0)
                {
                    Console.WriteLine("Invalid operation!");

                    break;
                }
                total += word1;
                Console.WriteLine($"Increase: {word1:f2}");



            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
