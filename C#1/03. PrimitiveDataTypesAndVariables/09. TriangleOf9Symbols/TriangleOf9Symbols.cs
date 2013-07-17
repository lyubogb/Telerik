using System;
using System.Text;

class TriangleOf9Symbols
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char symbol = '\u00A9';
        Console.WriteLine("  {0}  ",symbol);
        Console.WriteLine(" {0}{0}{0}  ", symbol);
        Console.WriteLine("{0}{0}{0}{0}{0}", symbol);
    }
}
