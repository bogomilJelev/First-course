using System;

namespace whileloopsex
{
    class Program
    {
        static void Main(string[] args)
        {
            string fvoritebook = Console.ReadLine();
            int bookcout = 0;

            while (true)
            {
                string bookname = Console.ReadLine();
                if (bookname == fvoritebook)
                {
                    Console.WriteLine($"You checked {bookcout} books and found it.");
                    break;
                }
                if (bookname == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {bookcout} books.");
                    break;
                }
                bookcout++;
            }
        }
    }
}
