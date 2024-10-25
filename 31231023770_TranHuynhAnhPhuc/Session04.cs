using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _31231023770_TranHuynhAnhPhuc
{
    internal class Session04
    {
        public static void Main()
        {
            Ex03();
        }

        /// <summary>
        /// to display certain values of the function x = y2 + 2y + 1
        /// </summary>
        static void Ex01() 
        {
            int x;
            for (int i = -5; i <= 5; i++) 
            {
                x = i * i + 2 * i + 1;
                Console.WriteLine("x = " + x);
            }
        }

        /// <summary>
        /// takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour(km/h) and miles per hour(miles/h)
        /// </summary>
        static void Ex02()
        {
            Console.WriteLine("Enter the distance (km): ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the hour: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minute: ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second: ");
            double s = double.Parse(Console.ReadLine());
            h = h + m / 60 + s / 3600;
            double kph = d / h;
            double mph = (d/1.609344d) / h;
            Console.WriteLine($"Kilometers per hour: {kph}");
            Console.WriteLine($"Miles per hour: {mph}");
        }

        /// <summary>
        /// checks if it is a vowel, a digit, or any other symbol
        /// </summary>
        static void Ex03()
        {
            Console.WriteLine("Enter the character");
            char c = char.Parse(Console.ReadLine());
            char[] lst = { 'a', 'o', 'u', 'e', 'i','A','O','U','E','I'};
            bool vowel = false;
            if (char.IsDigit(c))
            {
                Console.WriteLine("Your character is digit");
            }
            else
            {    foreach (char k in lst)
                {
                    if (k == c)
                    {
                        vowel = true;
                        break;
                    }
                }
                if (vowel)
                {
                        Console.WriteLine("Your character is vowel");
                }
                else
                {
                    Console.WriteLine("Other symbols");
                   
                }
            }
        }

        /// <summary>
        /// check whether a triangle is Equilateral, Isosceles or Scalene
        /// </summary>
        static void Ex04() 
        {
            Console.WriteLine("Enter side A: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side C: ");
            double c = double.Parse(Console.ReadLine());
            string cond1 = (a == b) ? "true" : "false";
            string cond2 = (b == c) ? "true" : "false";
            string cond3 = (c == a) ? "true" : "false";
            if (cond1 == "true" && cond2 == "true" && cond3 == "true")
            {
                Console.WriteLine("This is a equilateral triangle");
            }
            if (cond1 == "true" && cond2 == "true" || cond2 == "true" && cond3 == "true" || cond1 == "true" && cond3 == "true")
            {
                Console.WriteLine("This is a isosceles triangle");
            }
            if (cond1 == "false" && cond2 == "false" && cond3 =="false")
            {
                Console.WriteLine("This is a scalene triangle");
            }
            Console.ReadKey();
        }
    }
}
