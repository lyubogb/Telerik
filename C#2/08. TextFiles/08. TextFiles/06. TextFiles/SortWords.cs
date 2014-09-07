
// 6.
// Write a program that reads a text file containing a list of 
// strings, sorts them and saves them to another text file. 
// Example:
//  Ivan			George
//	Peter			Ivan
//	Maria			Maria
//	George			Peter


using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortWords
{
    static void Main()
    {
        string addressF1 = @"..\..\Names.txt";
        string outAddress = @"..\..\Result.txt";
        WriteInOutFile(outAddress, ReadMatrix(addressF1));
        foreach (var item in ReadMatrix(addressF1))
        {
            Console.WriteLine(item);
        } 
    }
    static List <string> ReadMatrix(string addrress)
    {
        List<string> list = new List<string>();
        StreamReader srF1 = new StreamReader(addrress);
        using (srF1)
        {
            string buffer = srF1.ReadLine();
            while (buffer != null)
            {
                list.Add(buffer);
                buffer = srF1.ReadLine();
            }
        }
        list.Sort();
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