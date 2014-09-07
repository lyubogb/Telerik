
// 21.
// Write a program that reads a string from the console and prints all
// different letters in the string along with information how many 
// times each letter is found. 

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class CountingLetters
{
    static void Main()
    {
        string givenText = " Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";
        string pattern = @"[A-Za-z]+";
        List<string> list = new List<string>();
        MatchCollection aa = Regex.Matches(givenText, pattern);
        foreach (var item in aa)
        {
            list.Add(item.ToString());
        }
        while (list.Count != 0)
        {
            int counter = 1;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[0] == list[i])
                {
                    counter++;
                    list.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(list[0] + " --> " + counter);
            list.RemoveAt(0);
        }
    }
}