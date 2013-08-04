// 20.
// Write a program that reads two numbers N and K 
// and generates all the variations of K elements 
// from the set [1..N]. 
// Example:	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

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
    static void Print(int numbersN, int elementsK, List<int>list )
    {

        for (int i = 1; i <= numbersN; i++)
        {
            list.Add(i);
            if (list.Count < elementsK)
            {
                Print(numbersN, elementsK, list);
            }
            else if (list.Count == elementsK)
            {
                Console.Write("{ ");
                foreach(var buffer in list)
                {
                    Console.Write("{0}, ",buffer);
                }
                Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop); 
                Console.WriteLine(" }");
            }
            list.RemoveAt(list.Count-1);
        }
    }
}

