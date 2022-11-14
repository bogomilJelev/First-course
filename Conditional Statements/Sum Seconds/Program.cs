using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondtTime = int.Parse(Console.ReadLine());
            int thirtTime = int.Parse(Console.ReadLine());
            int TotalTime = firstTime + secondtTime + thirtTime;
            int minute = TotalTime / 60;
            int seconds = TotalTime % 60;
            if (seconds < 10)
            {
                Console.WriteLine($"{minute}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minute}:{seconds}");
            }


        }
    }
}