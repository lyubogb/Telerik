// 03.
// Write a method that returns the last digit of given integer as an English word. 
// Examples: 512  "two", 1024  "four", 12309  "nine".


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('=',40));
        Console.WriteLine("Last digit is {0}",Metod(number));
    }

    static string Metod(int x)
    {
        string[] number = 
        {
            "Zero",
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
        };
        return number[(x %= 10)];
    }
}