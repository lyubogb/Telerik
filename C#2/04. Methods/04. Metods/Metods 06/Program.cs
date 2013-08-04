// 06.
// Write a method that returns the index of the first element in array 
// that is bigger than its neighbors, or -1, if there’s no such element.
// Use the method from the previous exercise.


using System;

class Program
{
    static void Main()
    {        
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int n = Metod(array);
        Console.WriteLine(@"
Write a method that returns the index of the first element in array 
that is bigger than its neighbors, or -1, if there’s no such element.
Use the method from the previous exercise.");
        Console.WriteLine(new string('=',50));
        Console.WriteLine("Return number is: {0}",n);
        Console.WriteLine();
    }

    static int Metod(int[] arr)
    {
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i - 1] < arr[i] && arr[i + 1] < arr[i])
            {
                return i;
            }
        }
        return -1;
    }
}