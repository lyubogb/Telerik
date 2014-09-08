// 06.
// Write a program to convert binary numbers to hexadecimal numbers (directly).


using System;

class ConvertBinToHex
{


    static void Main()
    {
        string outstring = null;
        string number = null;
        string number2 = "10100000000000000000000000001101";
        for (int i = 0; i < number2.Length; i++)
        {
            number += number2[number2.Length-1-i];
        }
        string digit = null;
        for (int x = 0; x < number.Length / 4; x++)
        {
            digit = null;
            for (int i = x * 4; i < x * 4 + 4; i++)
            {
                digit += number[i];
            }
            outstring = HexDigit(digit) + outstring;

        }
        Console.WriteLine(outstring);


    }
    static string HexDigit(string inputDigit)
    {
        string[] numbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        int buff = 0;
        for (byte i = 0; i < 4; i++)
        {
            if (Convert.ToString(inputDigit[i]) == "1")
            {
                buff += Convert.ToInt32(Math.Pow(2, i));
            }
        }
        return numbers[buff];
    }
}