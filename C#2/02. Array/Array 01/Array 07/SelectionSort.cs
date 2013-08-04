// 07.
// Sorting an array means to arrange its elements in increasing order.
// Write a program to sort an array. Use the "selection sort" algorithm:
// Find the smallest element, move it at the first position, 
// find the smallest from the rest, move it at the second position, etc.

using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("How members you wont in the array? ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int buffer = 0;
        int minNumber = 0;
        bool change = false;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter member {0} : ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            minNumber = array[i];
            change = false;

            for (int ii = i; ii < array.Length; ii++)
            {                
                if (minNumber > array[ii])
                {
                    minNumber = array[ii];
                    buffer = ii;
                    change = true;
                }                
            }

            if (change == true)
            {
                array[buffer] = array[i];
                array[i] = minNumber;
            }
        }

        Console.Write("New array is : ");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}