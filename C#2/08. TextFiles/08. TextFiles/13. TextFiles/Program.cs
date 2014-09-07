
// 13.
// Write a program that reads a list of words from a file words.txt and finds 
// how many times each of the words is contained in another file test.txt. 
// The result should be written in the file result.txt and the words should be
// sorted by the number of their occurrences in descending order. Handle all 
// possible exceptions in your methods.

using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string addres1 = @"..\..\Test.txt";
        string addres2 = @"..\..\Text.txt";
        string addres3 = @"..\..\output.txt";
        StreamReader sr1 = new StreamReader(addres1);
        StreamReader sr2 = new StreamReader(addres2);
        StreamWriter sw1 = new StreamWriter(addres3);
        
        using (sr1)
        {
            using (sr2)
            {
                using (sw1)
                {
                    string[] test = sr1.ReadToEnd().Split(' ');
                    string[] words = sr2.ReadToEnd().Split(' ');
                    int[] counts = new int[words.Length];
                    CountWords(test, words, counts);
                    Array.Sort(counts, words);
                    Array.Reverse(counts);
                    WriteResultToFile(sw1, words, counts);
                }
            }
        }
    }
    static void CountWords(string[] test, string[] words, int[] counts)
    {
        for (int j = 0; j < words.Length; j++)
        {
            for (int i = 0; i < test.Length; i++)
            {
                bool isEqual = CheckIfEqual(test, words, j, i);
                if (isEqual)
                {
                    counts[j]++;
                }
            }
        }
    }
    static void WriteResultToFile(StreamWriter sw1, string[] words, int[] counts)
    {
        StringBuilder outputLine = new StringBuilder();
        for (int i = 0; i < counts.Length; i++)
        {
            outputLine.Append(words[counts.Length - i - 1]);
            outputLine.Append(" = ");
            outputLine.Append(counts[i]);
            sw1.WriteLine(outputLine);
            outputLine.Clear();
        }
    }
    static bool CheckIfEqual(string[] test, string[] words, int j, int i)
    {
        bool isEqual = test[i].Equals(words[j], StringComparison.InvariantCultureIgnoreCase) ||
                       test[i].Equals(words[j] + '.', StringComparison.InvariantCultureIgnoreCase) ||
                       test[i].Equals(words[j] + ',', StringComparison.InvariantCultureIgnoreCase) ||
                       test[i].Equals(words[j] + ';', StringComparison.InvariantCultureIgnoreCase) ||
                       test[i].Equals(words[j] + ';', StringComparison.InvariantCultureIgnoreCase);
        return isEqual;
    }

}