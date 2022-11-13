using System;

namespace whileloopsex
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = (Console.ReadLine());
            int Totalsteps = 0;
            bool isfalse = false;
            while (output != "Going home")
            {
                int steps = int.Parse(output);
                Totalsteps += steps;

                if (Totalsteps >= 10000)
                {
                    isfalse = true;
                    break;
                }
                output = Console.ReadLine();
            }

            if (isfalse)

            {
                int stepover = Totalsteps - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepover} steps over the goal!");
            }
            else
            {
                int addsteps = int.Parse(Console.ReadLine());
                Totalsteps += addsteps;
                if (Totalsteps >= 10000)
                {
                    int stepover = Totalsteps - 10000;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepover} steps over the goal!");
                }
                else
                {
                    int stepoff = 10000 - Totalsteps;
                    Console.WriteLine($"{stepoff} more steps to reach goal.");
                }

            }


        }
    }
}
