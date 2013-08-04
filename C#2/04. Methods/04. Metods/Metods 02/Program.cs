// 02.
// Write a method GetMax() with two parameters that returns the bigger of two integers.
// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().


using System;

class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int seccondNumber = int.Parse(Console.ReadLine());
        int tirthNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('=', 10));
        Console.WriteLine(GetMax(GetMax(firstNumber, seccondNumber), tirthNumber));
    }

    static int GetMax(int x, int y)
    {
        if (x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
}