// 13.
// * Write a program that sorts an array of integers using 
// the merge sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] givenArr = new int[] { 10, 12, 2, 3, 1, 8, 7, 2, 14, 18, 28, 33, 44, 68, 78, 45 };
        int[] newArr = new int[16];
        MergeSort(givenArr, 0, givenArr.Length, newArr);

    }
    static void MergeSort(int[] arrIn, int a, int b, int[] arrOut)
    {
        int i = a;
        int j = b;

        while (i <= j)
        {
            int middlePoint = ((j - i) / 2);
            if (i + 1 < j)
            {
                MergeSort(arrIn, i, middlePoint, arrOut);
            }
            if (i + 1 > j)
            {
                MergeSort(arrIn, middlePoint, j, arrOut);
            }
        }
        if (i <= j)
        {
            Change(arrIn, i, j);
            i++;
            j--;
        }

    }
    static void Change(int[] arr, int a, int b)
    {
        int buffer = arr[a];
        arr[a] = arr[b];
        arr[b] = buffer;
    }
}

