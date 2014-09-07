
// 2.
// Write a program that reads a string, reverses it 
// and prints the result at the console.
// Example: "sample"  "elpmas".

using System;
using System.Text;

class RewersingString
{
    static void Main()
    {
        string str = "sample";
        StringBuilder sb = new StringBuilder();
        for (int i = str.Length-1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }
        Console.WriteLine(str);
        Console.WriteLine(sb);
    }
}