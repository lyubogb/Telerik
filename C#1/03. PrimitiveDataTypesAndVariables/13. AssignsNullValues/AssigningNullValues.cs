using System;

class AssigningNullValues
{
    static void Main()
    {
        int? valueA = null;
        double? valueB = null;
        Console.WriteLine("variableA = {0}", valueA);
        Console.WriteLine("variableB = {0}", valueB);
        valueA = 500;
        valueB = valueB + 300;
        Console.WriteLine("variableA = {0}", valueA);
        Console.WriteLine("variableB = {0}", valueB);
        valueA = 0x0078;
        valueB = valueB * 300;
        Console.WriteLine("variableA = {0}", valueA);
        Console.WriteLine("variableB = {0}", valueB);
        valueA = 2000*6;
        valueB = valueA + 300;
        Console.WriteLine("variableA = {0}", valueA);
        Console.WriteLine("variableB = {0}", valueB);

    }
}

