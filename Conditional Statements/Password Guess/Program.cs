using System;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "s3cr3t!P@ssw0rd";
            string cureent = Console.ReadLine();
            if (pass == cureent)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
