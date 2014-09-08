// 03. 
// Write a program to convert decimal numbers to their hexadecimal representation.

////////////////////////////////////////////////only for positive numbers
using System;

class ConvertDecToHex
{
    static void Main()
    {
        Console.WriteLine(Convert(64, 16));
    }
    static string Convert(int d, int b)
    {
        string h = null;
        for (; d != 0; d /= b)
        {
            h = GetChar(d % b) + h;
        }
        return h;
    }
    static char GetChar(int i)
    {
        if (i >= 10) return (char)('A' + i - 10);
        else return (char)('0' + i);
    }
}