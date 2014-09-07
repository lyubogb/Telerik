
// 04.
// Write a program that compares two text files line by line and 
// prints the number of lines that are the same and the number of
// lines that are different. Assume the files have equal number 
// of lines.

using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class ComparingFiles
{
    static void Main()
    {
        string address1 = @"..\..\text1.txt";
        string address2 = @"..\..\text2.txt";
        int currentRow = 0;
        string equal = null;
        string notEqual = null;
        string f1Str = null;
        string f2Str = null;
        Encoding w1251 = Encoding.GetEncoding("windows-1251");
        //////////////////////////////////////////////////////////////////////
        try
        {
            StreamReader srf1 = new StreamReader(address1, w1251);
            using (srf1)
            {
                f1Str = srf1.ReadLine();

                StreamReader srf2 = new StreamReader(address2, w1251);
                using (srf2)
                {
                    f2Str = srf2.ReadLine();
                    while (f1Str != null && f2Str != null)
                    {
                        currentRow++;
                        if (f1Str == f2Str)
                        {
                            equal += Convert.ToString(currentRow) + ", ";
                        }
                        else
                        {
                            notEqual += Convert.ToString(currentRow) + ", ";
                        }
                        f1Str = srf1.ReadLine();
                        f2Str = srf2.ReadLine();
                    }
                }
            }
            Console.WriteLine("Equal rows are : " + equal);
            Console.WriteLine("Notequal rows are : " + notEqual);
        }
        catch (System.OutOfMemoryException)
        {
            Console.WriteLine("OutOfMemory!");
        }
        catch (System.IO.IOException)
        {
            Console.WriteLine("I/O Error!");
        }
    }
}