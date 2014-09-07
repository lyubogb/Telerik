// 07.
// Write a program to convert from any numeral system of given 
// base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Numerics;


class UniversalConventor
{
    static void Main()
    {

        byte numberBits = 16;           // колко битово число търсим
        byte inputNumericSystem = 16;   // бройна система на входното число
        string inputValue = "8000";     // двайсетичното число "83BG" в десетично е -100 при 16 битови числа
        byte outputNumericSystem = 10;  // бройна система на изходното число

        // няма защита за неверни данни на входа (т.е. 20023 може да го приеме за бинарно, даже и резултат ще върне)
        //===========================
        string outputValue;
        string[] inputArr = new string[numberBits];
        Console.WriteLine("inputValue = {0}", inputValue);
        Console.WriteLine();

        BigInteger decValue;

        for (int i = 0; i < inputValue.Length; i++)
        {
            inputArr[i] = Char.ToString(inputValue[inputValue.Length - 1 - i]);
        }
        if (inputNumericSystem != 10)
        {
            decValue = ConvertToDec(inputArr, inputNumericSystem, numberBits);
        }
        else
        {
            decValue = BigInteger.Parse(inputValue);
        }

        //Console.WriteLine("decValue=" + decValue);

        if (outputNumericSystem == 10)
        {
            outputValue = decValue.ToString();
        }
        else
        {
            outputValue = ConvertDecToOther(decValue, outputNumericSystem, numberBits);
        }

        Console.WriteLine("outputValue: " + outputValue);
    }
    static BigInteger ConvertToDec(string[] inputArr, byte inputNumericSystem, byte numberBits)
    {
        bool signMinus = false; // Plus-false

        BigInteger max = (BigInteger)Math.Pow(2, numberBits - 1);

        BigInteger result = 0;

        for (int i = 0; i < inputArr.Length; i++)
        {
            if (inputArr[i] == "-")
            {
                signMinus = true;  // minus - true
            }
            result += (BigInteger)(DecDigit(inputArr[i]) * Math.Pow(inputNumericSystem, i));
        }

        if (result >= max)
        {
            result = -(2 * max - result);//
        }

        if (signMinus) // ако знака е отрицателен
        {
            result = -result;
        }

        return result;
    }

    static byte DecDigit(string inputDigit)
    {
        string[] numbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F",
                                          "G", "H", "I", "J", "K", "L", "M", "N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

        for (byte i = 0; i < numbers.Length; i++)
        {
            if (inputDigit == numbers[i])
            {
                return i;
            }
        }
        return 0;
    }

    static string ConvertDecToOther(BigInteger decValue, byte outputNumericSystem, byte numberBits)
    {
        BigInteger max = (BigInteger)Math.Pow(2, numberBits - 1);

        bool cuttingNumber = false;
        BigInteger cutNumber = 0;

        string[] numbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F",
                                          "G", "H", "I", "J", "K", "L", "M", "N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

        string result = null;
        int position = 0;

        while (decValue > max)
        {
            decValue /= 10;
            cuttingNumber = true;
            cutNumber = decValue;
        }

        if (decValue < 0)
        {
            decValue = (2 * max + decValue);
        }

        do
        {
            position = (int)(decValue % outputNumericSystem);
            result = numbers[position] + result;
            decValue /= outputNumericSystem;
        }
        while (decValue > 0);
        if (cuttingNumber)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cutting number! ({0})", cutNumber);
            Console.ResetColor();
            Console.WriteLine();
        }
        return result;
    }
}