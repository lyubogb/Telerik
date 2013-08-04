// 03.
// We are given a matrix of strings of size N x M. Sequences in the 
// matrix we define as sets of several neighbor elements located on the 
// same line, column or diagonal. Write a program that finds the longest 
// sequence of equal strings in the matrix. Example:

using System;

class FindTheLongestsequenceOfStrings
{
    static void Main()
    {
        string maxRepeats = null;
        int max = 0;
        int repeat = 0;
        Console.WriteLine(@"
03. We are given a matrix of strings of size N x M. Sequences in the 
    matrix we define as sets of several neighbor elements located on the 
    same line, column or diagonal. Write a program that finds the longest 
    sequence of equal strings in the matrix. ");

        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter M = ");
        int m = int.Parse(Console.ReadLine());
        //string[,] matrix = {
        //                   { "xx",  "xx", "ho", "xx"},
        //                   { "oo",  "ha", "xx", "kk"},
        //                   { "xx",  "bb", "aa", "xx"}
        //                   };

        string[,] matrix = new string[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Enter matrix [{0},{1}]", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                repeat = modelHorisontal(matrix, r, c);
                if (repeat > max)
                {
                    max = repeat;
                    maxRepeats = matrix[r, c];
                }
                repeat = modelVertical(matrix, r, c);
                if (repeat > max)
                {
                    max = repeat;
                    maxRepeats = matrix[r, c];
                }
                repeat = modelDiagonalUp(matrix, r, c);
                if (repeat > max)
                {
                    max = repeat;
                    maxRepeats = matrix[r, c];
                }
                repeat = modelDiagonalDown(matrix, r, c);
                if (repeat > max)
                {
                    max = repeat;
                    maxRepeats = matrix[r, c];
                }
            }
        }
        Console.WriteLine();
        for (int i = 0; i < max; i++)
        {
            Console.Write(maxRepeats + " ");
        }
        Console.WriteLine();

    }
    static int modelHorisontal(string[,] arr, int r, int c)
    {
        int count = 1;
        while (c < arr.GetLength(1) - 1)
        {
            if (arr[r, c] == arr[r, c + 1])
            {
                count++;
            }
            c++;
        }
        return count;
    }

    static int modelVertical(string[,] arr, int r, int c)
    {
        int count = 1;
        while (r + 1 < arr.GetLength(0) && c < arr.GetLength(1))
        {
            if (arr[r, c] == arr[r + 1, c])
            {
                count++;
            }
            r++;
        }
        return count;
    }
    static int modelDiagonalDown(string[,] arr, int r, int c)
    {
        int count = 1;

        while (r + 1 < arr.GetLength(0) && c + 1 < arr.GetLength(1))
        {
            if (arr[r, c] == arr[r + 1, c + 1])
            {
                count++;
            }
            r++;
            c++;
        }
        return count;
    }
    static int modelDiagonalUp(string[,] arr, int r, int c)
    {
        int count = 1;
        while (r - 1 >= 0 && c + 1 < arr.GetLength(1))
        {
            if (arr[r, c] == arr[r - 1, c + 1])
            {
                count++;
            }
            r--;
            c++;
        }
        return count;
    }
}