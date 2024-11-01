using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _31231023770_TranHuynhAnhPhuc
{
    internal class Session04
    {
       

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
            Console.ReadKey();
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
            Console.ReadKey();
        }

        /// <summary>
        /// checks if it is a vowel, a digit, or any other symbol
        /// </summary>
        static void Ex03()
        {
            Console.WriteLine("Enter the character");
            char c = char.Parse(Console.ReadLine());
            char[] lst = {'A','O','U','E','I'};
            bool vowel = false;
            if (char.IsDigit(c))
            {
                Console.WriteLine("Your character is digit");
            }
            else
            {    foreach (char k in lst)
                {
                    if (char.ToUpper(k) == c)
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
            Console.ReadKey();
        }

        /// <summary>
        /// check whether a given number is even or odd
        /// </summary>
        static void Ex04 ()
        {
            Console.WriteLine("Enter a number");
            int a = int.Parse(Console.ReadLine());
            bool mod = ((a % 2) == 0);
            if (mod)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// find the largest of three numbers
        /// </summary>
        static void Ex05()
        {
            Console.WriteLine("Enter the number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number c: ");
            int c = int.Parse(Console.ReadLine());
            int largest = a;
            if (a<b)
            {
                largest = b;
            }
            if (b<c)
            {
                largest = c;
            }
            Console.WriteLine($"The largest number is: {largest} ");
            Console.ReadKey();
        }

        /// <summary>
        /// accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies
        /// </summary>
        static void Ex06()
        {
            Console.WriteLine("Enter the  the value for X coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the  the value for Y coordinate: ");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant");
            }
            if (x == 0 && y == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies at the origin");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Check whether a triangle is Equilateral, Isosceles, or Scalene.
        /// </summary>
        static void Ex07()
        {
            double a, b, c;

            while (true)
            {
                Console.WriteLine("Enter side A: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side B: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side C: ");
                c = double.Parse(Console.ReadLine());
                if ((a + b) > c && (a + c) > b && (b + c) > a)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid input. The sum of any two sides must be greater than the third one. Please re-enter.");
                }
            }

            bool cond1 = (a == b);
            bool cond2 = (b == c);
            bool cond3 = (c == a);

            if (cond1 && cond2 && cond3)
            {
                Console.WriteLine("This is an equilateral triangle.");
            }
            else if (cond1 || cond2 || cond3)
            {
                Console.WriteLine("This is an isosceles triangle.");
            }
            else
            {
                Console.WriteLine("This is a scalene triangle.");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// read 10 numbers and find their average and sum
        /// </summary>
        static void Ex08()
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int number = i + 1;
                Console.WriteLine($"Enter the number {number}: ");
                int input = int.Parse(Console.ReadLine());
                sum += input;
            }
            double average = sum / 10;
            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine($"The average of the numbers is: {average}");
            Console.ReadKey();
        }

        /// <summary>
        /// display the multiplication table of a given integer
        /// </summary>
        static void Ex09()
        {
            Console.WriteLine("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"The multiplication table of {num}");
            Console.WriteLine($"{num} x 1 = {num * 1}");
            Console.WriteLine($"{num} x 2 = {num * 2}");
            Console.WriteLine($"{num} x 3 = {num * 3}");
            Console.WriteLine($"{num} x 4 = {num * 4}");
            Console.WriteLine($"{num} x 5 = {num * 5}");
            Console.WriteLine($"{num} x 6 = {num * 6}");
            Console.WriteLine($"{num} x 7 = {num * 7}");
            Console.WriteLine($"{num} x 8 = {num * 8}");
            Console.WriteLine($"{num} x 9 = {num * 9}");
            Console.WriteLine($"{num} x 10 = {num * 10}");
            Console.ReadKey();
        }

        /// <summary>
        /// display a pattern like triangles with a number
        /// </summary>
        static void Ex10()
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rows of triangles: ");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        /// <summary>
        /// display different patterns like triangles with number
        /// </summary>
        static void Ex11()
        {
            Console.WriteLine("Enter the rows of triangles: ");
            int row = int.Parse(Console.ReadLine());
            /// pattern 1
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            /// pattern 2
            int num1 = 1;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num1 + " ");
                    num1++;
                }
                Console.WriteLine();
            }

            /// pattern 3
            int num2 = 1;
            for (int i = 1; i <= row; i++)
            {
                for (int k = 1; k <= (row - i); k++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num2 + " ");
                    num2++;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        /// <summary>
        /// display the n terms of harmonic series and their sum
        /// </summary>
        static void Ex12()
        {
            Console.WriteLine("Enter a number: ");
            int x = int.Parse(Console.ReadLine());
            double sum = 0.0;

            Console.Write("1 + ");
            for (int i = 2; i <= x; i++)
            {
                Console.Write("1/" + i);
                if (i < x)
                {
                    Console.Write(" + ");
                }
                sum += 1.0/i ; 
            }

            Console.WriteLine($"\nSum = {sum + 1}");
            Console.ReadKey();
        }

        /// <summary>
        /// find the ‘perfect’ numbers within a given number range
        /// </summary>
        static void Ex13()
        {
            Console.WriteLine("Enter the start: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end: ");
            int end = int.Parse(Console.ReadLine());
            for ( int i = start; i <= end; i++)
            {
                int sum = 0;
                int n = 1;
                while (n < i)
                {
                    if (i % n == 0)
                    {
                        sum+= n;
                    }
                    n++;
                }
                if (i == sum)
                {
                    Console.WriteLine($"Perfect number: {i}");
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// determine whether a given number is prime or not
        /// </summary>
        static void Ex14()
        {
            Console.WriteLine("Enter a number: ");
            int x = int.Parse(Console.ReadLine());
            bool prime = true;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (!prime)
            {
                Console.WriteLine("Your number is not prime");
            }
            else
            {
                Console.WriteLine("Your number is prime");
            }
            Console.ReadKey();
        }
    }
}
