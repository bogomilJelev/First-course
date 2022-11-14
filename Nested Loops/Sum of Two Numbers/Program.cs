using System;
using System.Runtime.ExceptionServices;

namespace zad_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int magicnum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool fount = false;
            for (int i = first; i <= second; i++)
            {
                for (int c = first; c <= second; c++)
                {
                    counter++;
                    int sum = i + c;
                    if (sum == magicnum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {c} = {magicnum})");
                        fount = true;
                        break;
                    }

                }
                if (fount)
                {
                    break;
                }

            }
            if (!fount)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicnum}");

            }

        }


    }
}
