using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31231023770_TranHuynhAnhPhuc
{
    internal class Session05
    {



        /// <summary>
        /// Question 1
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Max (int a, int b, int c)
        {
            int maxNum = a;
            if (b > maxNum) 
            {
                maxNum = b;
            } 
            if (c > maxNum) 
            {
                maxNum = c;
            }
            return maxNum;
        }

        /// <summary>
        /// Question 2
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
       static int Factorial(int a)
        {
            int value = 1;
            for (int i = 1; i <= a; i++)
            {
                value *= i;
            }
            return value;
        }

    
        /// <summary>
        /// Question 3
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int Prime(int a)
        {
            int value = 0;
            bool prime = true;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (!prime)
            {
                value = 0;
            }
            else
            {
                value = 1;
            }
            return value;
        }


        /// <summary>
        /// Question 4.1
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>


        /* int start = 1;
            Console.WriteLine("Enter the number:");
            int end = int.Parse(Console.ReadLine());
            List<int> primeNum = Prime01(start, end);
            Console.WriteLine("Prime numbers:");
            Console.WriteLine(string.Join(", ", primeNum)); */

        static List<int> Prime01(int start, int end)
        {
            var list = new List<int>();
            for (int i = start +1 ; i < end; i++)
            {
                
                bool prime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    list.Add(i); 
                }
            }
                return list; 
        }

        /// <summary>
        ///  Question 4.2
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static List<int> Prime02(int n)
        {
            var list = new List<int>();
            for (int i = 2; list.Count < n ; i++)
            {

                bool prime = true;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    list.Add(i);
                }
                return list;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                List<int> primeNum = Prime02(n);
                Console.WriteLine("Prime numbers:");
                Console.WriteLine(string.Join(", ", primeNum));
            }
    }
}
