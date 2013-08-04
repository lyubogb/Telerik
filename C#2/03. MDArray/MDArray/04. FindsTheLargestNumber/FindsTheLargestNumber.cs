
// 04.
// Write a program, that reads from the console an array of N 
// integers and an integer K, sorts the array and using the method 
// Array.BinSearch() finds the largest number in the array which is ≤ K. 


using System;

class FindsTheLargestNumber
{
    static void Main()
    {    
        Console.WriteLine(@"

Write a program, that reads from the console an array of N integers 
and an integer K, sorts the array and using the method Array.BinSearch() 
finds the largest number in the array which is ≤ K.     ");
        //int k = 5;
        int buffer = 0;
        //int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0 ,3};
        ///////////////////////////////////////////////////////////
        Console.WriteLine(new string('=', 70));
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('=', 70));
        ///////////////////////////////////////////////////////////
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(new string('=', 70));
        ///////////////////////////////////////////////////////
        Array.Sort(array);
        buffer = Math.Abs( Array.BinarySearch(array, k));
        if (Array.BinarySearch(array, k) < 0)
        {
            Console.WriteLine(array[buffer-2]);
        }
        else
        {
            Console.WriteLine(array[buffer-1]);
        }       
    }
}