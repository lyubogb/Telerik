
// 10.
// Write a program that extracts from given XML 
// file all the text without the tags. Example:
// <?xml version="1.0"><student><name>Pesho</name>
// <age>21</age><interests count="3"><interest> 
// Games</instrest><interest>C#</instrest><interest> 
// Java</instrest></interests></student>

using System;
using System.IO;
using System.Text.RegularExpressions;

class ExtractXMLFormat
{
    static void Main()
    {
        try
        {
            string address1 = @"..\..\Text.txt";
            StreamReader reader = new StreamReader(address1);
            string regexStr = "<[^<>]+>";
            using (reader)
            {
                string word = reader.ReadToEnd();
                string[] dataInsideTags = Regex.Split(word, regexStr, RegexOptions.IgnorePatternWhitespace);
                foreach (string element in dataInsideTags)
                {
                    if (element != null && element != "")
                    {
                        Console.WriteLine(element + " ");
                    }
                }
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The file does not exist!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file does not exist!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory where the file should be does not exist!");
        }
        catch (IOException)
        {
            Console.WriteLine("IO Exception has accured!");
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("Out of memory!");
        }
    }
}