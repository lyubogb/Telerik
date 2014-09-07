
// 12.
// Write a program that removes from a text file all words listed in given 
// another text file. Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;


class RemovingWordsFromFile
{
    static void Main()
    {
        try
        {
            string address1 = @"../../words.txt";
            string address2 = @"../../input.txt";
            string address3 = @"../../output.txt";
            string regex = @"\b(" + String.Join("|", File.ReadAllLines(address1)) + @")\b";
            StreamReader input = new StreamReader(address2);
            using (input)
            {
                StreamWriter output = new StreamWriter(address3);
                using (output)
                {
                    for (string line; (line = input.ReadLine()) != null; )
                        output.WriteLine(Regex.Replace(line, regex, String.Empty));
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

