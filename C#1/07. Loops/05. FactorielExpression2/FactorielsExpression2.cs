
// 05. 
// Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class FactorielsExpression2
{
    static void Main()
    {
        do
        {
            uint inputNumberN;
            uint inputNumberK;
            bool xxx;
            BigInteger result = 1;
            do
            {
                Console.Write("Enter N = ");
                xxx = uint.TryParse(Console.ReadLine(), out inputNumberN);
                if (xxx != true || 1 >= inputNumberN)
                {
                    Console.WriteLine("Entered number N must be uint number and 1<N. Enter new value");
                    xxx = false;
                }
            } while (xxx == false);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("================================================");
            Console.ResetColor();

            do
            {
                Console.Write("Enter K = ");
                xxx = uint.TryParse(Console.ReadLine(), out inputNumberK);
                if (xxx != true || inputNumberN >= inputNumberK)
                {
                    Console.WriteLine("Entered number K must be uint number and N<K. Enter new value");
                    xxx = false;
                }
            } while (xxx == false);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("================================================");
            Console.ForegroundColor = ConsoleColor.Red;

            //////////////////////////////////////////////////////////////////////////////

            result = (Factorial(inputNumberK) * Factorial(inputNumberN)) / (Factorial(inputNumberK - inputNumberN));

            //////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("(N! * K!) / (K - N)! = {0}", result);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("================================================");
            Console.ResetColor();
        } while (true);
    }

    static BigInteger Factorial(uint numberN)
    {
        BigInteger factorial = 1;

        for (int i = 1; i <= numberN; i++)
        {
            factorial *= i;
        }
         return factorial;

    }
}
