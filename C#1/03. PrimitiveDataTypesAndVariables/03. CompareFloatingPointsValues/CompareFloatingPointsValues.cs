

using System;


class CompareFloatingPointsValues
{
    static void Main()
    {
        
        decimal Precision = 0.000001m;
        decimal variableA ;
        decimal variableB ;
        bool result;
         
        Console.WriteLine("Enter variableA");
        variableA = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter variableB");
        variableB = decimal.Parse(Console.ReadLine());
        
        variableA = Math.Round(variableA,6);
        variableB = Math.Round(variableB, 6);
        result = ((Math.Abs(variableA - variableB)) < Precision);
        Console.WriteLine("A = {0}", variableA);
        Console.WriteLine("B = {0}", variableB);

        Console.WriteLine("Result of  the comparison is {0}", result);

    }
}