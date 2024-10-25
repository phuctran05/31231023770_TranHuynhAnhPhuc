using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31231023770_TranHuynhAnhPhuc
{
    internal class Session03
    {
        

        /// <summary>
        /// convert from degrees Celsius to Kelvin and Fahrenheit
        /// </summary>
        static void Ex01()
        {
            Console.Write("Enter the number of degrees Celsius: ");
            double c = double.Parse(Console.ReadLine());
            double f = c * 10 / 18 + 32;
            double k = c + 273;
            Console.WriteLine($"Result: kelvin = {k} and fahrenheit = {f}");
            Console.ReadKey();
        }

        /// <summary>
        /// calculate the surface and volume of a sphere
        /// </summary>
        static void Ex02()
        {
            Console.Write("Enter the radius: ");
            double r = double.Parse(Console.ReadLine());
            double s = 4 * Math.PI * r * r;
            double v = 4/3 * Math.PI * r * r *r;
            Console.WriteLine($"Result: surface = {s} and volume = {v}");
            Console.ReadKey();
        }

        /// <summary>
        /// calculates the result of adding, subtracting, multiplying and dividing two numbers
        /// </summary>
        static void Ex03()
        {
            Console.Write("Enter the number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the number b: ");
            double b = double.Parse(Console.ReadLine());
            double sum = a + b;
            double subtract = a - b;
            double multiply = a * b;
            double divide = a / b;
            double mod = a % b;
            Console.WriteLine($"Result: {a} + {b} = {sum}, {a} - {b} = {subtract}, {a} * {b} = {multiply}, {a} / {b} = {divide}, {a} mod {b} = {mod}");
            Console.ReadKey();
        }
    }
}
