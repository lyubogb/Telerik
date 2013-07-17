
// 07.
// Write a program that reads a number N and calculates 
// the sum of the first N members of the sequence of Fibonacci: 
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …


using System;
class SumOfNFibonaccyNumbers
{
    static void Main()
    {
        do
        {
            byte members;
            int fibonicciNumber = 0;
            int Sum = 0;
            bool xxx;

            do
            {
                Console.Write("Enter number of members for calculating: ");
                xxx = byte.TryParse((Console.ReadLine()), out members);
            } while (xxx == false);

            for (int i = 0, bLasyNumber = 0, lastNumber = 1; i < members; i++)
            {
                fibonicciNumber = lastNumber + bLasyNumber;
                if (i == 0) fibonicciNumber = 0;
                else if (i == 1) fibonicciNumber = 1;
                else
                {
                    bLasyNumber = lastNumber;
                    lastNumber = fibonicciNumber;
                }
                Sum += fibonicciNumber;
            }
            Console.WriteLine("Sum of fibonicci members is {0}", Sum);
        } while (true);

    }
}
