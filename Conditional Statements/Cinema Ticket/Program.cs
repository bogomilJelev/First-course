using System;
using System.Diagnostics.CodeAnalysis;

namespace Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {

            string day = Console.ReadLine();
            int pri = 0;
            if (day == "Monday" || day == "Tuesday" || day == "Friday")
            {
                pri = 12;
            }
            else if (day == "Wednesday" || day == "Thursday")
            {
                pri = 14;
            }
            else
            {
                pri = 16;
            }
            Console.WriteLine(pri);

        }
    }
}
