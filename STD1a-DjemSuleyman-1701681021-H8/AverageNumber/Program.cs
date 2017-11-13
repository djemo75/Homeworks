using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = 0;
            int sum = 0;
            int reset = 1;
            Console.WriteLine("Enter number:");
            int first = int.Parse(Console.ReadLine());
            if (first < 1 || first > 255)
            {
                Console.WriteLine("There aren't even numbers in this diapson [1,255] !!!");
            }
            else
            {
                if (first % 2 == 0)
                {
                    sum += first;
                    numbers++;
                }
                while (reset!=0)
                {
                    Console.WriteLine("Enter number:");
                    int second = int.Parse(Console.ReadLine());
                    if (second == 0)
                    {
                        reset = 0;
                    }
                    if (second % 2 == 0 && second!=0)
                    {
                        numbers++;
                        sum += second;
                    }
                }
                if (sum == 0)
                {
                    Console.WriteLine("There aren't even numbers in this diapson [1,255] !!!");
                }
                else
                {
                    int result = sum / numbers;
                    Console.WriteLine("Average is "+result);
                }
            }
        }
    }
}
