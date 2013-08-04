// 08.
// Write a method that adds two positive integer numbers represented as arrays 
// of digits (each array element arr[i] contains a digit; the last digit is kept
// in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
// Напишете метод, който въвежда две положителни цели числа като масив от цифри 
// ( всеки елемент на arr[i] съдържа цифра, като последната цифра се пази в arr[0]).
// Всяко от добавяните числа може да има до 10'000 цифри. 
using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number ");
        string number1 = (Console.ReadLine());
        Console.Write("Enter seccond number ");
        string number2 = (Console.ReadLine());
        byte[] array1 = new byte[number1.Length];
        byte[] array2 = new byte[number2.Length];
        int xx = Math.Max(array1.Length, array2.Length);
        byte[] result = new byte[xx + 1];
        EnterNumbers(number1, array1);
        EnterNumbers(number2, array2);
        Add(array1, array2, result);
        Printing(array1);
        Console.WriteLine();
        Printing(array2);
        Console.WriteLine();
        Printing(result);
        Console.WriteLine();
    }

    static void EnterNumbers(string n, byte[] arr)
    {
        for (int i = 0; i < n.Length; i++)
        {
            arr[i] = Convert.ToByte(Convert.ToString(n[i]));
        }
        Array.Reverse(arr);
    }

    static void Add(byte[] a, byte[] b, byte[] result)
    {
        int x = Math.Max(a.Length, b.Length);
        byte buffer1 = 0;
        byte buffer2 = 0;
        int i = 0;
        for (i = 0; i < x; i++)
        {
            buffer1 = 0;
            byte firstNumber = 0;
            byte seccondNumber = 0;
            if (a.Length > i)
            {
                firstNumber = a[i];
            }
            if (b.Length > i)
            {
                seccondNumber = b[i];
            }
            buffer1 = (byte)((firstNumber + seccondNumber + buffer2) % 10);
            buffer2 = (byte)((firstNumber + seccondNumber + buffer2) / 10);
            result[i] = buffer1;
        }
        result[i] = buffer2;
    }

    static void Printing(byte[] arr)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr [arr.Length-1-i] );
        }
    }
}