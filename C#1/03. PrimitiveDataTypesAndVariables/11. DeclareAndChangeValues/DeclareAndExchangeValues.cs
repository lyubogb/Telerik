using System;

class DeclareAndExchangeValues
    {
    static void Main()
    {
        int Buffer;
        Console.WriteLine("Enter Your first number");
        int valueA = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Your second number");
        int valueB = int.Parse(Console.ReadLine());
        Buffer = valueA;
        valueA = valueB;
        valueB = Buffer;
        Console.WriteLine("after changig:");
        Console.WriteLine("first number = {0}\nsecon number = {1}", valueA, valueB);
    }
}

