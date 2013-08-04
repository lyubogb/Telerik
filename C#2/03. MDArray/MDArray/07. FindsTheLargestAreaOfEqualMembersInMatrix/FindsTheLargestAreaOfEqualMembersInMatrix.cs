// 07.
// * Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. 
//   Hint: you can use the algorithm "Depth-first search" or "Breadth-first search" (find them in Wikipedia).

using System;

class FindsTheLargestAreaOfEqualMembersInMatrix
{
    static void Main()
    {
        int[,] arr = new int[,]
        {
            {1,3,2,2,2,4},
            {3,3,3,2,4,4},
            {4,3,1,2,3,3},
            {4,3,1,3,3,1},
            {4,3,3,3,1,1}
        };


        bool[,] map = new bool[arr.GetLength(0), arr.GetLength(1)];
        int maxArea = 0;
        int currentArea = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                currentArea = 0;
                if (!map[i, j])
                {
                    currentArea += CountArea(map, arr, i, j);

                    if (currentArea > maxArea)
                    {
                        maxArea = currentArea;
                    }
                }
            }
        }
        Console.WriteLine("MaxArea={0}", maxArea);
    }

    static int CountArea(bool[,] map, int[,] arr, int i, int j)
    {
        int result = 1;
        map[i, j] = true;

        if (i - 1 >= 0 && !map[i - 1, j] && arr[i - 1, j] == arr[i, j])
        {
            result += CountArea(map, arr, i - 1, j);
        }
        if (i + 1 < arr.GetLength(0) && !map[i + 1, j] && arr[i + 1, j] == arr[i, j]) // down
        {
            result += CountArea(map, arr, i + 1, j);
        }
        if (j + 1 < arr.GetLength(1) && !map[i, j + 1] && arr[i, j + 1] == arr[i, j]) // right 
        {
            result += CountArea(map, arr, i, j + 1);
        }
        if (j - 1 >= 0 && !map[i, j - 1] && arr[i, j - 1] == arr[i, j]) // left 
        {
            result += CountArea(map, arr, i, j - 1);
        }
        return result;
    }
}
