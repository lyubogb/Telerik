// 01.
// Write a method that asks the user for his name and prints “Hello,
// <name>” (for example, “Hello, Peter!”). Write a program to test this method.

using System;

class Program
{
    static void Main()
    {
        string lit1 = "How is Your name?";
        Print(lit1);
    }

    static void Print(string str)
    {
        Console.Write(str + " ");
        string name = (Console.ReadLine());
        Console.WriteLine("Helo, {0}.\nThis is my first metod.", name);
    }
}