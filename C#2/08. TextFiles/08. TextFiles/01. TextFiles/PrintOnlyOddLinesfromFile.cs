
// 01.
// Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
using System.Text;

class PrintOnlyOddLinesfromFile
{
    static void Main()
    {
        string yy = null;
        string path1 = @"d:\text.txt";
        StreamReader sr = new StreamReader(path1);
        using (sr)
        {
            int row = 0;
            string xx = sr.ReadLine();
            while (xx != null)
            {
                row++;
                if (row % 2 != 0)
                {
                    yy = "Row " + row + ":  " + xx;
                    Console.WriteLine(yy);
                }
                xx = sr.ReadLine();
            }
        }
    }
    // ============================================= друго решение 
    //static void Main()
    //{
    //    int n = 1;

    //    using (StreamReader input = new StreamReader("../../Program.cs"))
    //        for (string line; (line = input.ReadLine()) != null; n++)
    //            if (n % 2 == 1) Console.WriteLine(line);
    //}

}