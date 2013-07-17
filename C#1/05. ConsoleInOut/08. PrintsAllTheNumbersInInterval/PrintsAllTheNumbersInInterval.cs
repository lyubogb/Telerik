
// 08.
// Write a program that reads an integer number n from the console 
// and prints all the numbers in the interval [1..n], each on a single line.

using System;

class PrintsAllTheNumbersInInterval
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Clear();
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }
}