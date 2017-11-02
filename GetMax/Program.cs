using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            double third = double.Parse(Console.ReadLine());

            double result = Math.Max(first,Math.Max(second,third));
            Console.WriteLine("The biggest number is {0}",result);
        }
    }
}
