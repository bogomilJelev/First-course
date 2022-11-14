using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double summ = 0;
            if (shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                summ = side * side;
            }
            else if (shape == "rectangle")
            {
                double side = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                summ = side * side2;


            }
            else if (shape == "circle")
            {
                double side = double.Parse(Console.ReadLine());
                summ = Math.PI * Math.Pow(side, 2);

            }
            else if (shape == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                summ = side * side2 / 2;
            }

            Console.WriteLine($"{summ:f3}");
        }

    }
}
