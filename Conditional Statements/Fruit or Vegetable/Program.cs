nausing System;
using System.Diagnostics.CodeAnalysis;

namespace magazin
{
    class Program
    {
        static void Main(string[] args)
        {

            string op = Console.ReadLine();
            string ask = "unknown";
            if (op == "banana" || op == "apple" || op == "kiwi" || op == "cherry" || op == "lemon" || op == "grapes")
            {
                ask = "fruit";
            }
            else if (op == "tomato" || op == "cucumber" || op == "pepper" || op == "carrot")
            {
                ask = "vegetable";
            }

            Console.WriteLine(ask);
        }
    }
}
