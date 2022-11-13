using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Dynamic;

namespace magazin
{
    class Program
    {
        static void Main(string[] args)
        {
            int fail = int.Parse(Console.ReadLine());
            int failcount = 0;
            int countproblems = 0;
            double summall = 0;
            string lastproblem = "";
            bool ask = false;


            while (fail > failcount)
            {
                string name = Console.ReadLine();
                if (name == "Enough")
                {
                    ask = true;
                    break;
                }



                double num = double.Parse(Console.ReadLine());
                if (num <= 4)
                {
                    failcount++;
                }


                countproblems++;
                summall += num;
                lastproblem = name;



            }
            double avarage = summall / countproblems;
            if (ask)
            {
                Console.WriteLine($"Average score: {avarage:f2}");
                Console.WriteLine($"Number of problems: {countproblems}");
                Console.WriteLine($"Last problem: {lastproblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {failcount} poor grades.");
            }


        }
    }
}
