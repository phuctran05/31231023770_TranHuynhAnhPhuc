using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31231023770_TranHuynhAnhPhuc
{
    internal class Session02
    {
        /// <summary>
        /// Add / Sum Two Numbers
        /// </summary>
        static void Ex01()
        {
            Console.Write("Enter the number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the number b: ");
            double b = double.Parse(Console.ReadLine());
            double sum = a + b;
            Console.WriteLine($"Result: {sum}");
            Console.ReadKey();
        }

        /// <summary>
        /// Swap Values of Two Variables
        /// </summary>
        static void Ex02()
        {
            Console.Write("Enter the number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the number b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Result before swapping: a: {a} and b: {b}");
            (a, b) = (b, a);
            Console.WriteLine($"Result after swapping: a: {a} and b: {b}");
            Console.ReadKey();
        }

        /// <summary>
        /// Multiply two Floating Point Numbers
        /// </summary>
        static void Ex03()
        {
            Console.Write("Enter the number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the number b: ");
            double b = double.Parse(Console.ReadLine());
            double result = a * b;
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }

        /// <summary>
        /// to convert feet to meter
        /// </summary>
        static void Ex04()
        {
            Console.Write("Enter feet: ");
            double feet = double.Parse(Console.ReadLine());
            double meter = feet * 0.3048;
            Console.WriteLine($"Result: {meter}");
            Console.ReadKey();
        }

        /// <summary>
        /// to convert Celsius to Fahrenheit and vice versa
        /// </summary>
        static void Ex05()
        {
            Console.Write("Enter Celsius: ");
            float cel = float.Parse(Console.ReadLine());
            Console.Write("Enter Fahrenheit: ");
            float fah = float.Parse(Console.ReadLine());
            double s1 = cel * 1.8 + 32;
            Console.WriteLine($"Celsius to Fahrenheit: {s1}");
            double s2 = (fah - 32) * 1.8;
            Console.WriteLine($"Fahrenheit to Celsius: {s2}");
            Console.ReadKey();
        }

        /// <summary>
        /// to find the Size of data types
        /// </summary>
        static void Ex06()
        {
            Console.WriteLine("Size of int: " + sizeof(int));
            Console.WriteLine("Size of float: " + sizeof(float));
            Console.WriteLine("Size of double: " + sizeof(double));
            Console.WriteLine("Size of short: " + sizeof(short));
            Console.WriteLine("Size of long: " + sizeof(long));
            Console.WriteLine("Size of decimal: " + sizeof(decimal));
            Console.WriteLine("Size of char: " + sizeof(char));
            Console.ReadKey();
        }

        /// <summary>
        /// to Print ASCII Value 
        /// </summary>
        static void Ex07()
        {
            Console.Write("Enter any character: ");
            char input = (char)Console.Read();
            int ascii = (int)input;
            Console.WriteLine($"ASCII: {ascii}");
            Console.ReadKey();
        }

        /// <summary>
        /// to Calculate Area of Circle
        /// </summary>
        static void Ex08()
        {
            double pi = Math.PI;
            Console.WriteLine("Enter the radius: ");
            double radius = double.Parse(Console.ReadLine());
            double area = pi * radius * radius;
            Console.WriteLine($"The area of circle is: {area}");
            Console.ReadKey();
        }

        /// <summary>
        /// to Calculate Area of Square
        /// </summary>
        static void Ex09()
        {
            Console.WriteLine("Enter the side of the square: ");
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            Console.WriteLine($"The area of square: {area}");
            Console.ReadKey();
        }

        /// <summary>
        /// to convert days to years, weeks and days
        /// </summary>
        static void Ex10()
        {
            Console.WriteLine("Enter the number of days: ");
            int numOfDay = int.Parse(Console.ReadLine());
            int year = numOfDay / 365;
            int week = (numOfDay % 365) / 7;
            int day = (numOfDay % 365) % 7;
            Console.WriteLine($"Result: {year} year(s) {week} week(s) {day} day(s)");
            Console.ReadKey();
        }
    }
}
