
// 10.
// Write a program to calculate the N-th Catalan number by given N.
// formula: (2n)!/((n+1)!*n!)

using System;
using System.Numerics;

class CatalanNumbers
{

    static void Main()
    {
        int n;
        bool xxx;
        BigInteger result;
        do
        {
            Console.WriteLine("(2n)!/((n+1)!*n!)");
            do
            {
                Console.Write("Enter integer number N = ");
                xxx = int.TryParse(Console.ReadLine(), out n);
                if (n < 0)
                {
                    xxx = false;
                }
            } while (xxx == false);


            result = (Factorial(2 * n)) / (Factorial(n + 1) * Factorial(n));
            Console.WriteLine("==============================\n" + result);
            Console.WriteLine();
        } while (true);
    }

    static BigInteger Factorial(int numberN)
    {
        BigInteger factorialN = 1;

        for (int i = 1; i <= numberN; i++)
        {
            factorialN *= i;
        }
        return factorialN;
    }
}
