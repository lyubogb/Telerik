// 08.
// Write a program that finds the sequence of maximal 
// sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} --> {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?


using System;

class FindsTheSequenceOfMaximalSum
{
    static void Main()
    {
        ///////////////////////////////////////////////////////
        int seqSum = 0;
        int maxSum = int.MinValue;
        int index = 0;
        Console.Write("How numbers have in the sequence? ");
        int sequence = int.Parse(Console.ReadLine());
        Console.Write("Length of array ");
        int l = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter nubers of array.");
        int[] array = new int[l];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter array {0} --> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        ///////////////////////////////////////////////////////

        for (int j = 0; j < l - sequence + 1; j++)
        {
            seqSum = 0;
            for (int i = 0; i < sequence; i++)
            {
                seqSum += array[i + j];
            }
            if (maxSum < seqSum)
            {
                maxSum = seqSum;
                index = j;
            }
        }

        ///////////////////////////////////////////////////////
        Console.Write("Sequence is : ");

        for (int i = index; i < index + sequence; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}
