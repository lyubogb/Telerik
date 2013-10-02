// 10.
// Write a program that finds in given array of integers 
// a sequence of given sum S (if present). 
// Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

using System;

class FindingSequenceWithGivenSumInArray
{
    static void Main()
    {
        Console.Write("Enter lenght of the array. --> ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter sum of finding. --> ");
        int givenSum = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter members of array.");
        int sum = 0;
       
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Member {0} -->  ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(new string('=', 30));       
        Console.Write("{");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + (i != array.Length - 1 ? ", " : "}, " + "S=" + givenSum));
        }

        Console.WriteLine();
        /////////////////////////////////////////////////////////////////////////////////
        for (int i = 0; i < array.Length; i++)  // start point
        {
            sum = 0;
            int j = i;
            while (sum < givenSum && j < array.Length)
            {
                sum += array[j];
                j++;
            }

            if (sum == givenSum)
            {
                Console.Write("{");
                for (int x = i; x < j; x++)
                {
                    Console.Write(array[x] + (x != j - 1 ? ", " : "}"));
                }
                Console.WriteLine();
            }
        }
        /////////////////////////////////////////////////////////////////////////////////
    }
}