// 01. 
// Write a program that fills and prints a matrix of size 
// (n, n) as shown below: (examples for n = 4)

using System;

class Prints4TypesOfMatrix
{
    static void Main()
    {
        int workMod = 0;
        int columns = 0;
        int rows = 0;
        int mod = 4;    // for models of the matrix from a to d
        int n = 4;
        int[,] matrix = new int[n, n];
        ////////////////////////////////////////////////////    
        while (workMod < mod)
        {
            Model(matrix, workMod);
            {
                columns = 0;
                rows = 0;
                for (rows = 0; rows < n; rows++)
                {
                    for (columns = 0; columns < n; columns++)
                    {
                        Console.Write("{0,4}", matrix[rows, columns]);
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                }

                workMod++;
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }

    static void Model(int[,] arr, int m)
    {
        int directUpDown = 0;
        int number = 1;
        int col = 0;
        int row = 0;
        switch (m)
        {
            case 0:
                {
                    col = 0;
                    row = 0;
                    number = 1;
                    for (col = 0; col < arr.GetLength(1); col++)
                    {
                        for (row = 0; row < arr.GetLength(0); row++)
                        {
                            arr[row, col] = number;
                            number++;
                        }
                    }

                    break;
                }

            case 1:
                {
                    directUpDown = 0;
                    col = 0;
                    row = 0;
                    number = 1;
                    for (col = 0; col < arr.GetLength(1); col++)
                    {
                        if (col % 2 == 0)
                        {
                            directUpDown = 0;
                        }
                        else
                        {
                            directUpDown = 1;
                            row--;
                        }

                        if (row < 0)
                        {
                            row = 0;
                        }

                        while (row < arr.GetLength(0) && row >= 0)
                        {
                            arr[row, col] = number;
                            number++;
                            if (directUpDown == 0)
                            {
                                row++;
                            }

                            if (directUpDown == 1)
                            {
                                row--;
                            }
                        }
                    }

                    break;
                }

            case 2:
                {
                    number = 1;
                    for (int n = arr.GetLength(1) - 1; n >= -(arr.GetLength(1)); n--)
                    {
                        row = n;
                        col = 0;
                        if (n < 0)
                        {
                            row -= n;
                            col -= n;
                        }

                        while (row < arr.GetLength(1) && col < arr.GetLength(0))
                        {
                            arr[row, col] = number;
                            number++;
                            row++;
                            col++;
                        }
                    }

                    break;
                }

            case 3:
                {
                    int minP = 0;
                    int maxP = arr.GetLength(0) - 1;
                    col = 0;
                    row = 0;
                    int intUpDown = 1;
                    number = 1;
                    while (minP <= maxP)
                    {
                        arr[row, col] = number;
                        number++;
                        if (row == maxP && col == maxP)
                        {
                            intUpDown = 0;
                        }

                        if (row == minP && col == minP + 1)
                        {
                            intUpDown = 1;
                            minP++;
                            maxP--;
                        }

                        if (intUpDown == 1)
                        {
                            if (row < maxP)
                            {
                                row++;
                            }
                            else
                            {
                                col++;
                            }
                        }

                        if (intUpDown == 0)
                        {
                            if (row > minP)
                            {
                                row--;
                            }
                            else
                            {
                                col--;
                            }
                        }
                    }

                    break;
                }
        }
    }
}
