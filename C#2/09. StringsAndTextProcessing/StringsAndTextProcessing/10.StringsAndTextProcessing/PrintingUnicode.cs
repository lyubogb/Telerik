
// 10.
// Write a program that converts a string to a sequence of C# Unicode character literals. 
// Use format strings. Sample input:
// Hi!
// Expected output:
// \u0048\u0069\u0021

using System;
using System.Text;

class PrintingUnicode
{
    static void Main()
    {
        string inputData = "Hi!";
        StringBuilder stringSB = new StringBuilder();
        for (int i = 0; i < inputData.Length; i++)
        {
            Console.Write(String.Format("\\u{0,4:x4}", (int)inputData[i]));
        }
        Console.WriteLine();
    }
}