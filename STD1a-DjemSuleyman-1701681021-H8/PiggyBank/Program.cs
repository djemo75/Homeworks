using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double sum = 0;
                int max = 999 * 999;
                Random random = new Random();
                for (int i = 1; i < 32; i++)
                {
                    int number = random.Next(1, max);
                    if (Math.Sqrt(number) >= 1 && Math.Sqrt(number) <= 300)
                    {
                        Console.WriteLine(i + "day - " + Math.Round(Math.Sqrt(number), 4) + "$");
                        sum += Math.Sqrt(number) * 5.1;
                    }
                    else if (Math.Sqrt(number) >= 301 && Math.Sqrt(number) <= 600)
                    {
                        Console.WriteLine(i + "day - " + Math.Round(Math.Sqrt(number), 4) + "$");
                        sum += Math.Sqrt(number) * 10.098;
                    }
                    else
                    {
                        Console.WriteLine(i + "day - " + Math.Round(Math.Sqrt(number), 4) + "$");
                        sum += Math.Sqrt(number) * 100.00001;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pigs are saved " + Math.Round(sum, 4) + "$ for 1 mounth.");
                Console.ResetColor();

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
