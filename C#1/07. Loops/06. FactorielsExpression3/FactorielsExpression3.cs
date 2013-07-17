
// 06.
// Write a program that, for a given two integer numbers N and X,
// calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

class FactorielsExpression3
{
    static void Main()
    {
        do
        {
            double inputNumberN;      // Members of expression
            double inputNumberX;
            double nFactoriel = 0;
            double Sum = 1;
            bool xxx;
            do
            {   // Entering number N .
                Console.Write("Enter N = ");
                xxx = double.TryParse(Console.ReadLine(), out inputNumberN);
                if (xxx != true) Console.WriteLine("Entered number N must be uint number. Enter new value");
            } while (xxx == false);
            do
            {   // Entering number X .
                Console.Write("Enter X = ");
                xxx = double.TryParse(Console.ReadLine(), out inputNumberX);
                if (xxx != true) Console.WriteLine("Entered number X must be uint number. Enter new value");
            } while (xxx == false);

            for (uint i = 1; i <= inputNumberN; i++)
            {
                for (uint ii = 1, factoriel = 1; ii <= i; ii++)
                {
                    nFactoriel = factoriel *= ii;
                }

                Sum += (nFactoriel / Math.Pow(inputNumberX, i));
            }

            Console.WriteLine("=============================================================================");
            Console.WriteLine("S = 1 + 1!/X + 2!/X^2 + ...... + N!/X^N = {0}", Sum);
            Console.WriteLine("=============================================================================");
            Console.WriteLine();
            
        } while (true);
    }
}