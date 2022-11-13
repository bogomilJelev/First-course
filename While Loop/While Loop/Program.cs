using System;
using System.Diagnostics;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string word = Console.ReadLine();
                if (word == "Stop")
                {
                    break;
                }
                Console.WriteLine(word);
            }
        }
    }
}
