using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31231023770_TranHuynhAnhPhuc
{
    internal class Session07
    {
        static void Main(string[] args)
        {
            int[,] arr = RandomMatrix();
            PrintMatrix(arr);
            int[,] transposedMatrix = TransposeMatrix(arr);
            PrintMatrix(transposedMatrix);
        }

        static int[,] RandomMatrix()
        {
            Console.WriteLine("Enter the rows: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the columns: ");
            int col = int.Parse(Console.ReadLine());
            int[,] randomMatrix = new int[row, col];
            Random random = new Random();
            for (int i = 0; i < randomMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomMatrix.GetLength(1); j++)
                {
                    randomMatrix[i,j] = random.Next(101);
                }
            }
            return randomMatrix;
        }

        static void PrintMatrix(int[,] randomMatrix)
        {
            for (int i = 0; i < randomMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomMatrix.GetLength(1); j++)
                {
                    Console.Write($"{randomMatrix[i,j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void PrintRow(int[,] randomMatrix) 
        {
            Console.WriteLine("Enter the i(th) row: ");
            int row = int.Parse(Console.ReadLine());
            for (int i = 0; i < randomMatrix.GetLength(1); i++)
            {
                Console.Write($"{randomMatrix[row-1,i]}\t");
            }
            Console.WriteLine();
        }
        static void PrintColumn(int[,] randomMatrix)
        {
            Console.WriteLine("Enter the i(th) column: ");
            int col = int.Parse(Console.ReadLine());
            for (int i = 0; i < randomMatrix.GetLength(0); i++)
            {
                Console.Write($"{randomMatrix[i,col-1]}\t");
            }
            Console.WriteLine();
        }

        static int MaxValue(int[,] randomMatrix)
        {
            int maxValue = -1; 
            foreach (int i in randomMatrix)
            {
                if (i > maxValue)
                {
                    maxValue = i;
                }
            }
               
            return maxValue;
        }

        static int MinValueInRow(int[,] randomMatrix)
        {
            int minValue = -1;
            Console.WriteLine("Enter the i(th) row: ");
            int row = int.Parse(Console.ReadLine());
            for (int i = 0; i < randomMatrix.GetLength(0); i++)
            {
                if (minValue < i)
                {
                    minValue = i;
                }
                Console.WriteLine();
                    
            }
            Console.WriteLine();

            return minValue;
        }

        static int MaxValueInRow(int[,] randomMatrix)
        {
            int minValue = -1;
            Console.WriteLine("Enter the i(th) col: ");
            int row = int.Parse(Console.ReadLine());
            for (int i = 0; i < randomMatrix.GetLength(1); i++)
            {
                if (minValue < i)
                {
                    minValue = i;
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            return minValue;
        }

        static int[,] TransposeMatrix(int[,] randomMatrix)
        {
            int[,] transposedmatrix = new int[randomMatrix.GetLength(1), randomMatrix.GetLength(0)];
            for (int i = 0; i < transposedmatrix.GetLength(0); i++)
            {
                for (int j = 0; j < transposedmatrix.GetLength(1); j++)
                {
                    transposedmatrix[i,j] = randomMatrix[j,i];
                }
                Console.WriteLine();
            }
            return transposedmatrix;
        }

        static void MainDiagonal(int[,] randomMatrix)
        {
            for (int i = 0; i < randomMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomMatrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{randomMatrix[i, j]}\t");  
                    }
                }
                Console.WriteLine();
            }
        }

        static void SecondaryDiagonal(int[,] randomMatrix)
        {
            for (int i = 0; i < randomMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomMatrix.GetLength(1); j++)
                {
                    if (i + j == randomMatrix.GetLength(0))
                    {
                        Console.Write($"{randomMatrix[i, j]}\t");
                    }
                }
                Console.WriteLine();
            }
        }
        
       
    }
}
