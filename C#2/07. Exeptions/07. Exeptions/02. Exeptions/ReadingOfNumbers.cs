
// 02.
// Write a method ReadNumber(int start, int end) that enters an integer 
// number in given range [start…end]. If an invalid number or non-number 
// text is entered, the method should throw an exception. Using this method 
// write a program that enters 10 numbers:
// 			a1, a2, … a10, such that 1 < a1 < … < a10 < 100


using System;

class ReadingOfNumbers
{
    static void Main()
    {
        int start = 0;
        int end = 100;
        int n = 10;
        int[] arr = new int[n];
        
Console.WriteLine("This program reads 10 number in the interval (1..100)\n" +
        "each entered number should be greater than the previous.");

        for (int i = 0; i < n; i++)
        {
            arr[i] = ReadNumber(start, end, i, n);
            start = arr[i];
        }
        Array.Sort(arr);
        foreach (var item in arr)
        {
            Console.Write(item + ", ");
        }
    }
    static int ReadNumber(int start, int end, int i, int n)
    {
        while (true)
        {
            int number = 0;
            int stop = 0;
            try
            {
                Console.Write("Enter integer number in arr[{0}] --> ", i);
                number = int.Parse(Console.ReadLine());
                if (number <= start || number > end+1-n+i)
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                else
                {
                    stop = end + 1 - n + i;
                    return number;
                }
            }
            catch (System.ArgumentNullException ane)
            {
                Console.WriteLine("Invalid numver! " + ane.Message);
            }
            catch (System.FormatException fe)
            {
                Console.WriteLine("Invalid number! " + fe.Message);
            }
            catch (System.OverflowException ofe)
            {
                Console.WriteLine("Invalid number! " + ofe.Message);
            }
            catch (System.ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine("Invalid number! " + "Entered number should by in the range from {0} to {1} ",start+1,end+1-n+i);
                Console.WriteLine(aoore.Message);
            }           
        }
    }
}