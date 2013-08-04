// 11.
// Write a method that adds two polynomials. Represent them as arrays 
// of their coefficients as in the example below:	x^2 + 5 = 1x^2 + 0x + 5 --> 501


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Program for solving the equation x^2 + 5 = 1x^2 + 0x + 5 ");
        Console.Write("What is the maximum degree of the polynomials ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('=', 50));
        decimal[] firstPolinomial = new decimal[n + 1];
        decimal[] seccondPolinomial = new decimal[n + 1];
        decimal[] result = new decimal[n + 1];
        EnteringCoefficients(firstPolinomial);
        EnteringCoefficients(seccondPolinomial);
        Console.WriteLine(new string('=', 50));
        PrintingArray(firstPolinomial);
        Console.WriteLine();
        PrintingArray(seccondPolinomial);
        Console.WriteLine();
        Add(firstPolinomial, seccondPolinomial, result);
        PrintingArray(result);
        Console.WriteLine();

    }
    static void EnteringCoefficients(decimal[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter coefficient for first polinomial {0} degree ==> ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
    }
    static void PrintingArray(decimal[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }

    }
    static void Add(decimal[] arr1, decimal[] arr2, decimal[] result)
    {

        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] + arr2[i];
        }
    }    
}