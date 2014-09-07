
// 02.
// Write a program that concatenates two text files into another text file.

using System;
using System.IO;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

class AddTwoFiles
{
    static string firstAddress = @"..\..\text1.txt";
    static string seccondAddress = @"..\..\text2.txt";
    static string outAddress = @"..\..\outtext.txt";
    static string firstStr = null;
    static string seccondStr = null;
    static string outStr = null;
    static void Main()
    {
        firstStr = read(firstAddress);
        seccondStr = read(seccondAddress);
        outStr = firstStr + "\r\n" + seccondStr;
        write(outStr, outAddress);
    }
    static string read(string inAddress)
    {
        string buffer = null;
        StreamReader sr = new StreamReader(inAddress);
        using (sr)
        {
            buffer = sr.ReadToEnd();
        }
        return buffer;
    }
    static void write(string buffer, string outAddress)
    {
        StreamWriter sw = new StreamWriter(outAddress);
        using (sw)
        {
            sw.WriteLine(buffer);
        }
    }
}