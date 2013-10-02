
// 2.
// Write a program that reads two arrays from the 
// console and compares them element by element.


using System;

class CompareTwoArraysElementByElement
{
    static void Main()
    {
        int count = 0;

        Console.WriteLine(@"
2. Write a program that reads two arrays from the 
console and compares them element by element.  ");

        Console.WriteLine();
        Console.WriteLine(new string('=', 55));
        Console.WriteLine("How members You wont to be have in the array");
        int x = int.Parse(Console.ReadLine());
        decimal[] array1 = new decimal[x];
        decimal[] array2 = new decimal[x];
        Console.WriteLine("Enter members of first array.");
        for (int i = 0; i < x; i++)
        {
            array1[i] = decimal.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter members of seccond array.");
        for (int i = 0; i < x; i++)
        {
            array2[i] = decimal.Parse(Console.ReadLine());
        }
        for (int i = 0; i < x; i++)
        {
            if (array1[i] != array2[i])
            {
                Console.WriteLine(new string('=', 55));
                Console.WriteLine("No, arr in te arrays are different");
                break;
            }
            count += 1;
            if (count == x)
            {
                Console.WriteLine(new string('=', 55));
                Console.WriteLine("Yes, arr of the arrays are equal");
            }
        }
    }
}