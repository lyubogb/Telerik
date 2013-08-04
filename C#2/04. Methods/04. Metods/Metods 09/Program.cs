// 09.
// Write a method that return the maximal element in a portion of array of 
// integers starting at given index. Using it write another method that 
// sorts an array in ascending / descending order.
// Напишете метод който връща най големия по стойност елемент на част от 
// масив от цели числа, работеща между два индекса.Използвайки го напишете 
// друг метод който сортира един масив в възходящ /низходящ ред.


using System;

class Program
{
    static void Main()
    {
        int[] array = { 33, 8, 9, 1, 11, 4, 66, 15, 6, 0, 10 };
        Sort(array, 0, array.Length, 0);
        Print(array);
        Sort(array, 0, array.Length, 1);
        Print(array);

    }
    private static int MaxNumber(int[] arr, int lowIndex)
    {
        int index = 0;
        for (int i = lowIndex; i < arr.Length; i++)
        {
            if (arr[index] < arr[i])
            {
                index = i;
            }
        }
        return index;
    }
    private static void Sort(int[] arr, int min, int max, int des)
    {
        int[] a = new int[arr.Length];
        for (int i = min; i < arr.Length - 1; i++)
        {
            int x = MaxNumber(arr, 0);
            if (des == 0)
            {
                a[a.Length - 1 - i] = arr[x];
            }
            else
            {
                a[i] = arr[x];
            }
            Array.Clear(arr, x, 1);
        }
        Array.Copy(a, arr, a.Length);
    }
    private static void Change(int[] arr, int a, int b)
    {
        int buffer = arr[a];
        arr[a] = arr[b];
        arr[b] = buffer;
    }
    private static void Print(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

}