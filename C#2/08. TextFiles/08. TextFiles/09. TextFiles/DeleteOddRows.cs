
// 09.
// Write a program that deletes from given text file all 
// odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Collections.Generic;

class DeleteOddRows
{
    static void Main()
    {
        string addressF1 = @"..\..\Text.txt";
        string outAddress = @"..\..\Text.txt";
        WriteInOutFile(outAddress, ReadMatrix(addressF1));
    }
    static List<string> ReadMatrix(string addrress)
    {
        int rows = 0;
        List<string> list = new List<string>();
        StreamReader srF1 = new StreamReader(addrress);
        using (srF1)
        {
            string buffer = srF1.ReadLine();
            while (buffer != null)
            {
                rows++;
                if (rows % 2 == 0)
                {
                    list.Add(buffer);
                }
                buffer = srF1.ReadLine();
            }
        }
        return list;
    }
    static void WriteInOutFile(string address, List<string> arr)
    {
        StreamWriter sr = new StreamWriter(address);
        using (sr)
        {
            foreach (var item in arr)
            {
                sr.WriteLine(item);
            }
        }
    }
}