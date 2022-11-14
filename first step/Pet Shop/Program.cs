using System;

namespace asda
{
    class Program
    {
        static void Main(string[] args)
        {

            double dogs = double.Parse(Console.ReadLine());
            double animal = double.Parse(Console.ReadLine());
            double dogfood = dogs * 2.50;
            double animalfood = animal * 4;
            double all = dogfood + animalfood;
            Console.WriteLine($"{all} lv.");


        }
    }
}