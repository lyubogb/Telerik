
// 07.
// Write a program that replaces all occurrences of the substring
// "start" with the substring "finish" in a text file. 
// Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplacesWords
{
    static void Main()
    {        
        string address1 = @"..\..\Text.txt";
        string address2 = @"..\..\OutputText.txt";
        StreamReader sr = new StreamReader(address1);
        using (sr)
        {
            StreamWriter sw = new StreamWriter(address2);
            using (sw)
            {
                string buffer = sr.ReadLine();
                while (buffer != null)
                {
                    string inBuffer = buffer.Replace("start", "finish");
                    sw.WriteLine(inBuffer);
                    buffer = sr.ReadLine();
                }
            }
        }
    }
}