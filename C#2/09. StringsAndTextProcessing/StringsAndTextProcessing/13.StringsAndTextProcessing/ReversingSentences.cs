
// 13.
// Write a program that reverses the words in given sentence.
// Example: "C# is not C++, not PHP and not Delphi!" --> "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ReversingSentences
{
    static void Main()
    {
        string result = null;
        string text = "C# is not C++, not PHP and not Delphi!";
        string punctuation = @"\s+|,\s*|\.\s*|!\s*"; 
        string wordPattern = @"(\w[^\s\,\!]*)";
        List<string> separators = new List<string>();
        List<string> words = new List<string>();
        foreach (var word in Regex.Split(text, wordPattern))
        {
            words.Add(word);
        }
        foreach (Match w in Regex.Matches(text, punctuation))
        {
            separators.Add(w.Value);
        }
        for (int i = 0; i < words.Count; i++)
        {
            int ii = 0;
            if (words[i]!="")
            {
                result += words[words.Count-i];
            }
            else
            {
                result += separators[ii];
                ii++;
            }
        }
        Console.WriteLine(result);
    }
}