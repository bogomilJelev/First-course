﻿namespausing System;

namespace zad_6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int summ = i * j;
                    Console.WriteLine($"{i} * {j} = {summ}");
                }
            }
        }
    }
}
