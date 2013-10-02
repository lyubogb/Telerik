// 03.
// Write a program that compares two char arrays
// lexicographically (letter by letter).


using System;

class ComparesTwoCharArraysLexicographically
{
    static void Main()
    {
        int comp = 1;

        Console.WriteLine(@"
03. Write a program that compares two char arrays 
lexicographically (letter by letter).");

        Console.WriteLine(new string('=', 50));
        Console.WriteLine("Enter number of array members .");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter members of the first array.");
        char[] array1 = new char[x];

        for (int i = 0; i < x; i++)
        {
            array1[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter members of the seccond array.");
        char[] array2 = new char[x];

        for (int i = 0; i < x; i++)
        {
            array2[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < x; i++)
        {
            if (array1[i] == array2[i])
            {
                continue;
            }

            comp = 0;
            if (array1[i] < array2[i])
            {
                Console.WriteLine("First array is lexicographically before seccond");
                break;
            }
            else
            {
                Console.WriteLine("Seccond array is lexicographically before first");
                break;
            }
        }

        if (comp == 1)
        {
            Console.WriteLine("Arrays are equal");
        }
    }
}
