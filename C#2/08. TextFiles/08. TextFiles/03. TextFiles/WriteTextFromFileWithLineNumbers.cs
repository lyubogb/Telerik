
// 03.
// Write a program that reads a text file and inserts 
// line numbers in front of each of its lines. 
// The result should be written to another text file.


using System;
using System.IO;
using System.Text;

class WriteTextFromFileWithLineNumbers
{
    static void Main()
    {
        string yy = null;
        string path1 = @"d:\text.txt";
        string path2 = @"d:\text2.txt";
        StreamReader sr = new StreamReader(path1);       
        using (sr)
        {
            StreamWriter sw = new StreamWriter(path2,false,Encoding.GetEncoding("windows-1251"));
            using (sw)
            {
                int row = 0;
                string xx = sr.ReadLine();
                while (xx != null)
                {
                    row++;
                    yy = "Row " + row + ":  " + xx ;
                    sw.WriteLine(yy);
                    xx = sr.ReadLine();
                }
            }
        }       
    }
}