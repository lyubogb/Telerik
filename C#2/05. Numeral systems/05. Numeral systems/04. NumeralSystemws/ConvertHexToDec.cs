// 04.
// Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class ConvertHexToDec
{
    static void Main()
    {
        int bits = 16;
        string hexNumber = "6CDD";//Console.ReadLine();    //1CA-->458
        Console.WriteLine(hexNumber);
        Console.WriteLine(ConvertHexToDec(hexNumber,bits));
    }
    static int ConvertHexToDec(string hexNumber,int bits)
    {
        int result1 = 0;
        int result = 0;
        int num = 0;
        int step = hexNumber.Length - 1;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (hexNumber[i])
            {
                case 'A':
                    {
                        num = 10;
                        break;
                    }
                case 'B':
                    {
                        num = 11;
                        break;
                    }
                case 'C':
                    {
                        num = 12;
                        break;
                    }
                case 'D':
                    {
                        num = 13;
                        break;
                    }
                case 'E':
                    {
                        num = 14;
                        break;
                    }
                case 'F':
                    {
                        num = 15;
                        break;
                    }
                default:
                    {
                        num = int.Parse(Convert.ToString(hexNumber[i]));
                        break;
                    }
            }
            result += num * Step(16, step--);
        }
        var maxnumber = (Math.Pow(2, bits-1));
        if (maxnumber<=result)
        {
            result = -1*(Convert.ToInt32( 2*maxnumber - result));
        }
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
