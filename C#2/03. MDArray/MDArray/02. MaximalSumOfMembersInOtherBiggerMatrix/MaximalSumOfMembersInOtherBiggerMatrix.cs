// 02.
// Write a program that reads a rectangular matrix of size N x M 
// and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSumOfMembersInOtherBiggerMatrix
{
    static void Main()
    {
        Random random = new Random();
        Console.Write("Number of rows in the matrix (N>=3) N = ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Number of columns in the matrix (M>=3) M = ");
        int y = int.Parse(Console.ReadLine());
        int[,] matrix = new int[x, y];

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                //Console.Write("Matrix [{0}, {1}]", i, j);
                matrix[i, j] = random.Next(1, 100); //int.Parse(Console.ReadLine());
            }
        }

        int lastsum = int.MinValue;
        int sum = 0;
        int a = 0;
        int b = 0;
        int n = 0;
        int p = 0;

        for (int i = 0; i < matrix.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 2; j++)
            {
                for (n = i; n < i + 3; n++)
                {
                    for (p = j; p < j + 3; p++)
                    {
                        sum += matrix[n, p];
                    }
                }

                if (lastsum < sum)
                {
                    lastsum = sum;
                    a = i;
                    b = j;
                }

                sum = 0;
            }
        }

        Console.WriteLine(new string('=', 50));
        Console.WriteLine("In given matrix ");
        Console.WriteLine();

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write("{0,6}", matrix[i, j] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine(new string('=', 50));
        Console.WriteLine("Matrix [3,3] with maximal sum of numbers is :");
        Console.WriteLine();

        for (int i = a; i < a + 3; i++)
        {
            for (int j = b; j < b + 3; j++)
            {
                Console.Write("{0,6}", matrix[i, j] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine(new string('=', 50));
        Console.WriteLine("Sum of numbers in the matrix is {0}", lastsum);
        Console.WriteLine();
    }
}