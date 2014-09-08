// 01.
// Write a program to convert decimal numbers to their binary representation.
// Напишете програма за преобразуване на десетични числа в техния двоичен код.

/////////////////////////////////////////////////// for all numbers

using System;

class ConvertDecToBin
{
    static void Main()
    {
        Random ran = new Random();
        int iNumber = ran.Next(-1000, 1000);
        Console.WriteLine(iNumber);
        Console.WriteLine(ConvDecToBin(iNumber));
    }
    static string ConvDecToBin(int i)
    {
        int u = 32;
        byte[] arr1 = new byte[u];
        string result = null;
        if (i < 0)
        {
            arr1[arr1.Length - 1] = 1;
            i = int.MaxValue - Math.Abs(i + 1);
        }
        for (int x = 0; x < u - 1; x++)
        {
            arr1[x] += (byte)(i % 2);
            i /= 2;
            if (i == 0)
            {
                break;
            }
        }
        foreach (var item in arr1)
        {
            result = item + result;
        }
        return result;
    }
}
//////////////////////////////////////////////// only for positive numbers
//using System;

//class Program
//{
//    static void Main()
//    {
//        Random ran = new Random();
//        int iNumber = ran.Next(0, 1000);
//        Console.WriteLine(iNumber);
//        Console.WriteLine(Convert(iNumber, 2));
//    }
//    static string Convert(int n, int b)
//    {
//        string number = null;
//        for (; n != 0; n /= b)
//        {
//            number = Char(n % b) + number;
//        }
//        return number;
//    }
//    static char Char(int i)
//    {
//        if (i >= 10)
//        {
//            return (char)('A' + i - 10);
//        }
//        else
//        {
//            return (char)('0' + i);
//        }
//    }
//}
