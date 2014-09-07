
// 5.
// You are given a text. Write a program that changes the text in 
// all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
// The tags cannot be nested. 

// Example:
// We are living in a <upcase>Yellow Submarine</upcase>. 
// We don't have <upcase>anything</upcase> else.

// The expected result:
// We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Text.RegularExpressions;

class ChangeText
{
    static void Main()
    {
        string regexString = @"<upcase>(?<regexString>.*?)</upcase>";
        string givenText = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(Regex.Replace(givenText, regexString, aaa => aaa.Groups[1].Value.ToUpper()));
    }
}