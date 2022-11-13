namespusing System;

namespace whileas
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = double.MinValue;
            while (true)
            {
                string number = Console.ReadLine();
                if (number == "Stop")
                {
                    break;
                }
                double number1 = double.Parse(number);
                if (number1 > max)
                {
                    max = number1;
                }
            }
            Console.WriteLine($"{max}");
        }
    }
}
