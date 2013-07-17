
// 03
// Write a program that reads from the console a sequence of N integer
// numbers and returns the minimal and maximal of them.

using System;

class MinAndMaxOfSequenceOfNumbers
{
    static void Main()
    {
        do
        {
            int inputNumberA;
            int inputNumberB;
            int minNumber = 0;
            int maxNumber = 0;
            bool xxx;
            do
            {
                Console.WriteLine("How numbers You want for sequence.");
                xxx = int.TryParse(Console.ReadLine(), out inputNumberA);
                if (inputNumberA < 0)
                {
                    Console.WriteLine("N must by integer number");
                    xxx = false;
                }
            } while (xxx == false);

            int[] array = new int[inputNumberA];
            for (int i = 0; i < inputNumberA; i++)
            {
                do
                {
                    Console.WriteLine("Enter numbers for comparing.");
                    Console.WriteLine("");
                    xxx = int.TryParse(Console.ReadLine(), out inputNumberB);
                    if (xxx == false)
                    {
                        Console.WriteLine("Numbers for comparing must by integer numbers");
                    }
                } while (xxx == false);
                array[i] = inputNumberB;
            }

            minNumber = array[0];
            maxNumber = array[0];

            foreach (int bbb in array)
            {
                minNumber = Math.Min(minNumber, bbb);
                maxNumber = Math.Max(maxNumber, bbb);
            }

            Console.WriteLine("minNumber = {0}", minNumber);
            Console.WriteLine("maxNumber = {0}", maxNumber);
        } while (true);
    }
}
