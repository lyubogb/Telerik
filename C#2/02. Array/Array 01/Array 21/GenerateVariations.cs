// 21.
// Write a program that reads two numbers N and K and 
// generates all the combinations of K distinct elements 
// from the set [1..N]. 
// Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}


using System;
using System.Collections.Generic;

class GenerateVariations
{
    static void Main()
    {
        int numbersN = int.Parse(Console.ReadLine());  // до кое число да брои
        int elementsK = int.Parse(Console.ReadLine()); // колко числа е подмножеството
        List<int> list = new List<int>();

        Print(numbersN, elementsK, list);
    }
    static void Print(int numbersN, int elementsK, List<int> list)
    {
        int i = 1;
        if (list.Count > 0)
        {
            i = list[list.Count - 1] + 1;
        }

        for (; i <= numbersN; i++)
        {
            list.Add(i);
            if (list.Count < elementsK)
            {
                Print(numbersN, elementsK, list);
            }
            else if (list.Count == elementsK)
            {
                Console.Write("{ ");
                foreach (var buffer in list)
                {
                    Console.Write("{0}, ", buffer);
                }
                Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
                Console.WriteLine(" }");
            }
            list.RemoveAt(list.Count - 1);
        }
    }
}