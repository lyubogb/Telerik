
// 09.
// Write a program to print the first 100 members of the sequence of Fibonacci:
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class Prints100MembersOfFibonacci
{
    static void Main()
    {
        Console.Write("Enter how members of sequence of Fibonacci You want to print: ");
        int n = int.Parse(Console.ReadLine());
        decimal F;                // F(n)
        decimal bF = 1;           // F(n-1)
        decimal bbF = 0;          // F(n-2)
        Console.WriteLine("000" + "-->" + bbF);
        Console.WriteLine("001" + "-->" + bF);
        for (int i = 2; i <= n; i++)
        {
            F = bF + bbF;
            Console.WriteLine("{0:000}" + "-->" + F, i);
            if (F < bF)
            { 
                break;
            }
            bbF = bF;
            bF = F;
        }

    }
}