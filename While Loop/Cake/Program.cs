using System;

namespace zad_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int duljine = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            int diff = 0;
            bool cakefinish = false;
            int total = duljine * visochina;
            int pice = 0;
            while (comand != "STOP")
            {
                int comand2 = int.Parse(comand);
                total -= comand2;
                pice++;
                diff = Math.Abs(total);
                if (total <= 0)
                {
                    cakefinish = true;
                    break;
                }

                comand = Console.ReadLine();
            }
            if (cakefinish)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(diff)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{total} pieces are left.");
            }
        }
    }
}
