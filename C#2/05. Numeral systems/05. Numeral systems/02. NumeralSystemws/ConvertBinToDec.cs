// 02.
// Write a program to convert binary numbers to their decimal representation.
//using System;

using System;

class Program
{
    static void Main()
    {
        int bits = 32;             //how bits have in the number
        string num = "10000001100010000010000110011011";      //Console.ReadLine();
        Console.WriteLine(num);
        Console.WriteLine(Step(2, 1));
        Console.WriteLine(ConvertBinToDec(num, bits));
    }
    static int ConvertBinToDec(string n, int bits)
    {

        ///////////////////////////////
        int result = 0;
        int negative = 0;
        if (n.Length == bits)
        {
            if (true)
            {
                if (n[0] == '1')
                {
                    negative = 1;
                }
            }
        }
        for (int i = 0; i < n.Length - negative; i++)
        {
            if (n[n.Length - 1 - i] == '1')
            {
                result += Step(2, i);
            }
        }
        /////////////////////////////////

        if (n.Length == bits)
        {
            if (n[0] == '1')
            {
                result = -1 * (Step(2, bits - 1) - Math.Abs(result));
            }
        }

        /////////////////////////////////
        return result;
    }
    static int Step(int num, int step)
    {
        int result = 1;
        for (int i = 0; i < step; i++)
        {
            result *= num;
        }
        return result;
    }
}