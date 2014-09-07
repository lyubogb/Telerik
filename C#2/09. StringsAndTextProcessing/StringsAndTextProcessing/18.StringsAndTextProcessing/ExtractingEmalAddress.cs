
// 18.
// Write a program for extracting all email addresses from 
// given text. All substrings that match the format 
// <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

class ExtractingEmalAddress
{
    static void Main()
    {
        string text = "Write a program for extra. cting all email addresses from given text. All substrin lyubogb@mail.bg lyubogb@gmail.com gs that match evgeni_gb@mail.bg the format <identifier>@<host>…<domain> should be recognized as emails.";
        string pattern = @"\w+@\w+\.\w{2,4}";
        MatchCollection aa = Regex.Matches(text, pattern);
        foreach (Match item in aa)
        {
            Console.WriteLine(item);
        }
    }
}