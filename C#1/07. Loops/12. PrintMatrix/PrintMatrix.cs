
// 12.
// Write a program that reads from the console a positive
// integer number N (N < 20) and outputs a matrix
//    N=3                    N=4
//    1 2 3                  1 2 3 4 
//    2 3 4                  2 3 4 5
//    3 4 5                  3 4 5 6
//                           4 5 6 7

using System;

class PrintMatrix
{
    static void Main()
    {
        do
        {
            uint inputNumberN;
            bool xxx;
            do
            {
                Console.Write("Enter N = ");
                xxx = uint.TryParse(Console.ReadLine(), out inputNumberN);
                if (xxx != true || 20 <= inputNumberN)
                {
                    Console.WriteLine("Entered number N must be uint number. Enter new value");
                    xxx = false;
                }
            } while (xxx == false);

            Console.WriteLine();
            for (int i = 1; i <= inputNumberN; i++)
            {
                for (int ii = 1, iii = i; ii <= inputNumberN; ii++)
                {
                    Console.Write("{0,2}  ", iii++);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
        } while (true);

    }
}
