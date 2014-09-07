
// 05.
// Write a program that reads a text file containing a square 
// matrix of numbers and finds in the matrix an area of size 
// 2 x 2 with a maximal sum of its elements. The first line in 
// the input file contains the size of matrix N. Each of the 
// next N lines contain N numbers separated by space. 
// The output should be a single number in a separate text file.
// Example:
//  4
//  2 3 3 4
//  0 2 3 4	---->17
//  3 7 1 2
//  4 3 3 2


using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class MaxSumInMatrix
{
    static void Main()
    {
        string addressMatrix = @"..\..\matrix.txt";
        string addressResult = @"..\..\result.txt";
        string result = Convert.ToString(maxSum(ReadingMatrix(addressMatrix), 2, 2));
        WriteInOutFile(addressResult, result);
        Console.WriteLine(result);
    }
    static int maxSum(int[,] matrix, int a, int b)
    {
        int n = 0;
        int p = 0;
        int sum = 0;
        int maxSum = 0;
        for (int i = 0; i < (matrix.GetLongLength(0) - a); i++)
        {
            for (int j = 0; j < matrix.GetLongLength(1) - b; j++)
            {
                for (n = i; n < i + a; n++)
                {
                    for (p = j; p < j + b; p++)
                    {
                        sum += matrix[n, p];
                    }
                }
                maxSum = Math.Max(maxSum, sum);
                sum = 0;
            }
        }
        return maxSum;
    }
    static int[,] ReadingMatrix(string addressMatrix)
    {
        int n = 0;
        StreamReader srMatrix = new StreamReader(addressMatrix);
        using (srMatrix)
        {
            n = int.Parse(srMatrix.ReadLine());
            int[,] matrix = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                string[] numbers = srMatrix.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(numbers[j]);
                }
            }
            return matrix;
        }
    }
    static void WriteInOutFile(string addressResult, string result)
    {
        StreamWriter swMatrix = new StreamWriter(addressResult);
        using (swMatrix)
        {
            swMatrix.WriteLine(result);
        }
    }
}