
// 02
// Write a program that prints all the numbers from 1 to N,
// that are not divisible by 3 and 7 at the same time.

using System;

class AllNumbersThatDevidesBy7and3
{
    static void Main()
    {
        do
        {
            int inputNumber;
            bool xxx;

            do
            {
                xxx = int.TryParse(Console.ReadLine(), out inputNumber);
            } while (xxx == false);
            Console.WriteLine("===========");

            for (int i = 1; i <= inputNumber; i++)
            {
                if (!(i % 3 == 0 && i % 7 == 0))
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
        } while (true);
    }
}
