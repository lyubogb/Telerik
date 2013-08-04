// 15.
// Write a program that finds all prime numbers in the range 
// [1...10 000 000]. Use the sieve of Eratosthenes algorithm 
// (find it in Wikipedia).

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] array = new bool[n];
        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            while (array[i] == true)
            {
                i++;
            }
            for (int j = i; j < n; j += i)
            {
                if (i!=j)
                {
                    array[j] = true;
                }
            }
        }
        for (int i = 2; i < n; i++)
        {
           if (array[i] == false)
            {
                Console.WriteLine(i);
            } 
        }
    }
}
