
// 01
// Write a program that prints all the numbers from 1 to N.

using System;

class AllNumbersToN
{
    static void Main()
    {
        do
        {
            int inputsNumber;
            bool xxx;
            do
            {
                Console.WriteLine("Enter a integer number.");
                xxx = int.TryParse(Console.ReadLine(), out inputsNumber);

            } while (xxx == false);
            Console.WriteLine("=======");

            for (int i = 1; i <= inputsNumber; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        } while (true);
    }
}
