// 11.
// Write a program that finds the index of given element in a sorted 
// array of integers by using the binary search algorithm (find it in Wikipedia).

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter length of the array ");
        int x = int.Parse(Console.ReadLine());
        int[] array = new int[x];
        for (int i = 0; i < x; i++)
        {
            Console.Write("Enter array {0} --> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter element to search for: ");
        int number = int.Parse(Console.ReadLine());
        Array.Sort(array);
        Console.WriteLine("Sort array is :");
        for (int i = 0; i < x; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Search(array, 0, array.Length - 1, number);
    }

    static void Search(int[] arr, int start, int end, int element)
    {
        int middle = start + (end - start) / 2;
        if (element < arr[middle])
        {
            Search(arr, start, middle - 1, element);
        }
        else if (element > arr[middle])
        {
            Search(arr, middle + 1, end, element);
        }
        else
        {
            Console.WriteLine("The index of {0} in array is {1}", element, middle);
            return;
        }
    }
}