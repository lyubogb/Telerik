
// 10.
// Write a program to calculate the sum (with accuracy of 0.001): 
// 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class CalculateTheSum
{
    static void Main()
    {

        double result = 0;
        double k;
        double precision = 0.001;
        // first number a


        ////////////////////////////////////////////////////////////////////////////

        for (double i = 1; i < (1 / precision); i++)
        {
            k = (Math.Pow(-1, (i % 2)));
            if (i == 1)
            {
                k = 1;
            }
            result = result + (k / i);
        }

        ///////////////////////////////////////////////////////////////////////////

        Console.WriteLine("Sum = " + Math.Round(result, 3));
    }
}

