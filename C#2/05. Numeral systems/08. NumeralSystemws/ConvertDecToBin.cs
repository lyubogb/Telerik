// 08.
// Write a program that shows the binary representation of 
// given 16-bit signed integer number (the C# type short).

using System;

class ConvertDecToBin
{
    static void Main()
    {
        Random ran = new Random();
        int iNumber = ran.Next(Int16.MinValue, Int16.MaxValue);
        Console.WriteLine(iNumber);
        Console.WriteLine(ConvDecToBin(iNumber));
        Console.WriteLine(int.MaxValue);
    }
    static string ConvDecToBin(int i)
    {
        int u = 16;
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
