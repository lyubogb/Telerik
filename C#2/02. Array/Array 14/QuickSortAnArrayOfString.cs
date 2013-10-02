// 14.
// Write a program that sorts an array of strings using
// the quick sort algorithm (find it in Wikipedia).

using System;

class QuickSortAnArrayOfString
{
    static void Main()
    {
        string[] arrayOfString = new string[] { "sgdh", "drt", "acro", "aaa", "bbba", "daa", "DYHJGOL", "cdgyhj", "rfds", "sdf", "fgr", "sd", "jgkd", "XDCFV", "Dhj", "hsk", "vjfgl" };
        Quicksort(arrayOfString, 0, arrayOfString.Length - 1);
        foreach (var word in arrayOfString)
        {
            Console.WriteLine(word);
        }
    }
    static void Quicksort(IComparable[] arr, int left, int right)
    {
        int i = left;
        int j = right;
        object pivot = arr[(left + right) / 2];

        while (i <= j)
        {
            while (arr[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (arr[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                Change(arr, i, j);
                i++;
                j--;
            }
        }
        ////////////////////////////////////////////////////////
        if (left < j)
        {
            Quicksort(arr, left, j);
        }

        if (i < right)
        {
            Quicksort(arr, i, right);
        }
    }
    static void Change(object [] arr , int i, int j)
    {
        object tmp = arr[i];
        arr[i] = arr[j];
        arr[j] = tmp;
    }
}