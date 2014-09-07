
// 08.
// Modify the solution of the previous problem to replace 
// only whole words (not substrings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class RreplaceOnlyWholeWords
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
                    sw.WriteLine(Regex.Replace(buffer, @"(\W|^)start(\W|$)", "$finish$2"));
                    buffer = sr.ReadLine();
                }
            }
        }
    }
}