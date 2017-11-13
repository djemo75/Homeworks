using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {



                do
                {
                    Console.WriteLine("Do you want to calculate some numbers ? (yes or no)");
                }
                while (Console.ReadLine() != "yes");

                Console.WriteLine("Enter first number:");
                int firstnumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                int secondnumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter operation:");
                char operation = char.Parse(Console.ReadLine());
                switch (operation)
                {
                    case '+':
                        double result = (firstnumber + secondnumber) * 1.1;
                        Console.WriteLine("Result is {0}", Math.Round(result, 2));
                        Console.WriteLine("****************************\n****************************\n****************************");
                        break;
                    case '-':
                        double max = Math.Max(firstnumber, secondnumber);
                        double min = Math.Min(firstnumber, secondnumber);
                        double result2 = Math.Pow(max, 2) - min;
                        Console.WriteLine("Result is {0}", Math.Round(result2, 2));
                        Console.WriteLine("****************************\n****************************\n****************************");
                        break;
                    case '*':
                        double result3 = firstnumber * Math.Sqrt(secondnumber);
                        Console.WriteLine("Result is {0}", Math.Round(result3, 2));
                        Console.WriteLine("****************************\n****************************\n****************************");
                        break;
                    case '/':
                        if (secondnumber != 0)
                        {
                            double result4 = firstnumber / secondnumber;
                            Console.WriteLine("Result is {0}", Math.Round(result4, 2));
                            Console.WriteLine("****************************\n****************************\n****************************");
                        }
                        else
                        {
                            Console.WriteLine("Error !!! You can't divide to 0 !!!");
                            Console.WriteLine("****************************\n****************************\n****************************");
                        }
                        break;
                }


            }
        }
    }
}
