
// 14.
// A dictionary is stored as a sequence of text lines containing 
// words and their explanations. Write a program that enters a word 
// and translates it by using the dictionary. Sample dictionary:
// .NET – platform for applications from Microsoft
// CLR – managed execution environment for .NET
// namespace – hierarchical organization of classes

using System;
using System.Text.RegularExpressions;

class Dictionary
{
    static void Main()
    {
        string dictData = @".NET  –  platform for applications from Microsoft
        CLR  –  managed execution environment for .NET
        namespace  –  hierarchical organization of classes
        ";
        while (true)
        {
            Console.Write("ENTER YOUR WORD : ");
            string searchWord = Console.ReadLine();
            string pattern = searchWord + @"(\s*?) \– (\s+?)((.|\s)+?)\r";
            MatchCollection xxx = Regex.Matches(dictData, pattern, RegexOptions.IgnoreCase);
            if (xxx.Count > 0 && searchWord.Length>0)
            {
                foreach (var item in xxx)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("This word is not exist in dictionary");
            }
            Console.WriteLine("Press any key for entering new word\nor Ctrl+C for EXIT.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}