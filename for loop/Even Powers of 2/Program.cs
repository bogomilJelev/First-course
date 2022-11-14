using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = int.Parse(Console.ReadLine());
            double sum = 2;
            for (double i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(sum, i));
                }

            }
        }
    }
}
