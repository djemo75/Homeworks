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
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number:");
            int third = int.Parse(Console.ReadLine());

            int result = Math.Max(first, Math.Max(second, third)); ;
            Console.WriteLine("The biggest number is {0}", result);
        }
    }
}
