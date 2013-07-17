
// 09.
// In the combinatorial mathematics, the Catalan numbers 
// are calculated by the following formula: (2n)!/((n+1)!*n!)

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int numberN = 5;//                      <<============= Enter new int number for calculating            
        BigInteger result;
        Console.WriteLine("(2n)!/((n+1)!*n!)\n \nfor N={0}", numberN);
        result = (Factorial(2 * numberN)) / (Factorial(numberN + 1) * Factorial(numberN));
        Console.WriteLine("==============================\nResult = {0}\n",result);
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
