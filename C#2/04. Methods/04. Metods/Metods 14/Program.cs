// 14.
// Write methods to calculate minimum, maximum, average,
// sum and product of given set of integer numbers.
// Use variable number of arguments.

using System;
using System.Collections.Generic;
using System.Numerics;

class MinMaxAverageSumAndProduct
{
    static void Main()
    {
        List<int> list = new List<int>();
        Input(list);
        Console.WriteLine("Min value : {0}", MinValue(list));
        Console.WriteLine("Max value : {0}", MaxValue(list));
        Console.WriteLine("Average value : {0}", Average(list));
        Console.WriteLine("Sum : {0}", Sum(list));
        Console.WriteLine("Product : {0}", Product(list));
        Console.WriteLine();
    }
    static void Input(List<int> list)
    {
        int input = 0;
        Console.WriteLine("Entering of the numbers. \nFor exit enter empty value!");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out input))
            {
                list.Add(input);
            }
            else
            {
                break;
            }
        }
    }

    static int MinValue(List<int> list)
    {
        int min = int.MaxValue;
        foreach (var item in list)
        {
            if (item < min)
            {
                min = item;
            }
        }

        return (min);
    }

    static int MaxValue(List<int> list)
    {
        int max = int.MinValue;
        foreach (var item in list)
        {
            if (item > max)
            {
                max = item;
            }
        }

        return (max);
    }

    static BigInteger Sum(List<int> list)
    {
        BigInteger sum = 0;
        foreach (var item in list)
        {
            sum += item;
        }
        return (sum);
    }

    static decimal Average(List<int> list)
    {
        return ((decimal)(Sum(list) / list.Count));
    }

    static BigInteger Product(List<int> list)
    {
        BigInteger product = 1;
        foreach (var item in list)
        {
            product *= item;
        }
        return (product);
    }
}