using System;

namespace zad_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int summ2 = 0;
            for (int i = 0; i <= number; i++)
            {
                for (int j = 0; j <= number; j++)
                {
                    for (int c = 0; c <= number; c++)
                    {
                        int summ = i + j + c;
                        if (summ == number)
                        {
                            summ2++;
                        }
                    }
                }

            }
            Console.Write($"{summ2}");
        }
    }
}
