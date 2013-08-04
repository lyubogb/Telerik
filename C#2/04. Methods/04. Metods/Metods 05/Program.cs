// 05.
// Write a method that checks if the element at given position in given
// array of integers is bigger than its two neighbors (when such exist).


using System;

class Program
{
    static void Main()
    {
        int givenPosition = 7;
        int[] array = { 1, 2, 5, 4, 7, 6, 7, 8, 9, 7, 0 };
        Console.WriteLine(@"
Write a method that checks if the element at given position in given
array of integers is bigger than its two neighbors (when such exist).");
        Console.WriteLine();
        Console.WriteLine("Number on position {1} is{0} bigger.", Metod(array,givenPosition)?"":"n't",givenPosition);
        Console.WriteLine();
    }

    static bool Metod(int[] arr, int i)
    {
        return (arr[i - 1] < arr[i] && arr[i + 1] < arr[i]);
    }
}