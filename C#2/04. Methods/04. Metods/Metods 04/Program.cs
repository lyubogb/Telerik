// 04.
// Write a method that counts how many times given number appears in given array. 
// Write a test program to check if the method is working correctly.

using System;

class Program
{
    static void Main()
    {
        int number = 12;
        int[] array = { 1, 2, 3, 5, 3, 4, 7, 8, 7, 3, 9, 0, 6 };
        Console.WriteLine("Number {1} is repeated {0} times. ", Method(array, number), number); 
    }

    static int Method(int[] arr, int n)
    {
        int counter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == n)
            {
                counter++;
            }
        }

        return counter;
    }
}