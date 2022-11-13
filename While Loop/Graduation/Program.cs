using System;

namespace whileas
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int classs = 1;
            double coutgrade = 0;
            int failedcout = 0;
            while (classs <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    classs++;
                }
                else
                {
                    failedcout++;
                }

                if (failedcout == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {classs} grade");
                    break;
                }
                coutgrade += grade;
                double avarage = coutgrade / 12;
                if (classs == 13)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {avarage:f2}");
                }
            }

        }
    }
}
