// 06.
// Write a program that reads two integer numbers N and K and an 
// array of N elements from the console. Find in the array those 
// K elements that have maximal sum.

using System;

class FindingInTheArrayKElementsWithMaximalSum
{
    static void Main()
    {
        // Inicialising N and K numbers and creating array with N members
        Console.Write("N = ");
        int N = int.Parse(Console.ReadLine());
        int result = 0;
        int[] array = new int[N];
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        // Inicialising of the arrays members
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Enter {0} member of the Array", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        //////////////////////////////////////////////////////////////////////
        Array.Sort(array);
        for (int i = 0; i < k; i++)
        {
            result += array[array.Length - i - 1];
        }
       
        Console.Write("Sum of K arr that have maximal sum is ");
        Console.WriteLine(result);
    }
}
