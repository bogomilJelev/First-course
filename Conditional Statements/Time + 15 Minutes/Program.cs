using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            minute = minute + 15;
            if (minute > 59)
            {
                hours = hours + 1;
                minute = minute - 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            if (minute < 10)
            {
                Console.WriteLine($"{hours}:0{minute}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minute}");
            }

        }

    }
}
