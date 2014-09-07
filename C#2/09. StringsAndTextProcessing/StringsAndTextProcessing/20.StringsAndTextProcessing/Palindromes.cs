
// 20.
// Write a program that extracts from a given text 
// all palindromes, e.g. "ABBA", "lamal", "exe".


using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Palindromes
{
    static void Main()
    {
        StringBuilder text = new StringBuilder(" Write a pro exe gram that reads a string from ABBA the console and prints all different LAMAL letters in the string along with info EXE rmation how many times each letter is found.");
        List<string> pal = new List<string>();

        string wordPattern = @"[A-Za-z]+";

        foreach (var item in Regex.Matches(text.ToString(), wordPattern))
        {
            for (int i = 0, j = item.ToString().Length - 1; i <= j && item.ToString()[i] == item.ToString()[j]; i++, j--)
            {
                if ((i == j || i + 1 == j) && i != 0)
                {
                    pal.Add(item.ToString());
                }

            }
        }
        foreach (var item in pal)
        {
            Console.WriteLine(item);
        }
    }
}