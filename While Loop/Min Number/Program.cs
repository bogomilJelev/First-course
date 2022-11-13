using System;

namespace whileas
{
    class Program
    {
        static void Main(string[] args)
        {
            double min = double.MaxValue;
            while (true)
            {
                string number = Console.ReadLine();
                if (number == "Stop")
                {
                    break;
                }
                double number1 = double.Parse(number);
                if (number1 < min)
                {
                    min = number1;
                }
            }
            Console.WriteLine($"{min}");
        }
    }
}
