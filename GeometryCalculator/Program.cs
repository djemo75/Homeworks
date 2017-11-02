using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option (triangle, square or radians):");
            string option = Console.ReadLine();
            switch (option)
            {
                case "triangle":
                    Console.WriteLine("Enter side:");
                    double side = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter height:");
                    double height = double.Parse(Console.ReadLine());

                    double result = side * height / 2;
                    Console.WriteLine("The area of triangle is {0}", result);
                break;

                case "square":
                    Console.WriteLine("Enter side:");
                    double side2 = double.Parse(Console.ReadLine());
                    double result2 = side2 * side2;
                    Console.WriteLine("The area of triangle is {0}", result2);
                break;

                case "radians":
                    Console.WriteLine("Enter the degrees you want to transform in radians:");
                    double degrees = double.Parse(Console.ReadLine());
                    double result3 = Math.PI * degrees / 180;

                    Console.WriteLine("Your degrees in radians are = {0}", result3);
                    break;
                default:
                    Console.WriteLine("Incorrect option!!! Try again!");
                    break;
            }
        }
    }
}
