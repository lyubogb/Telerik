// 05.
// Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class ConverHexToBin
{
    static void Main()
    {
        string result1 = null;
        int bits = 32;
        string Str = null;
        string number = "EDC5478A";
        int hexDigit = 0;
        for (int i = 0; i < number.Length; i++)
        {
            hexDigit = DecDigit(Convert.ToString(number[number.Length -1 - i]));
            for (int ii = 0; ii < 4; ii++)
            {
                result1 = Convert.ToString(hexDigit % 2) + result1;
                hexDigit /= 2;
            }
        }
        Console.Write(number + " --> ");
        Console.WriteLine(result1);

    }
    static byte DecDigit(string inputDigit)
    {
        string[] numbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

        for (byte i = 0; i < numbers.Length; i++)
        {
            if (inputDigit == numbers[i])
            {
                return i;
            }
        }
        return 0;
    }
}