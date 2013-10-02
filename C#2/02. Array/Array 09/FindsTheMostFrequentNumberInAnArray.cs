// 09.
// Write a program that finds the most frequent number in an array. 
// Example:
// {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} --> 4 (5 times)


using System;

class FindsTheMostFrequentNumberInAnArray
{
    static void Main()
    {
        Console.WriteLine("How long will be array");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int reg = 0;
        int count = 0;
        int frequentNumber = 0;
        int maxFreq = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter array {0} --> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length; i++)
        {
            count = 0;
            reg = array[i];
            for (int ii = 0; ii < array.Length; ii++)
            {
                if (array[ii] == reg)
                {
                    count++;
                }
            }
            if (count > maxFreq)
            {
                maxFreq = count;
                frequentNumber = reg;
            }
        }
        Console.WriteLine(new string ('=',30));
        Console.WriteLine(frequentNumber + " ({0} times)", maxFreq);
    }
}