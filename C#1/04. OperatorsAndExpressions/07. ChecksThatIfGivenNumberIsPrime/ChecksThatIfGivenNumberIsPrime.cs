
// Write an expression that checks if given positive
// integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class ChecksThatIfGivenNumberIsPrime
{
    static void Main()
    {

        Console.Write("Enter integer number N ( N <= 100 ) : ");
        byte valueN = byte.Parse(Console.ReadLine());
        byte limit = 100;
        double limitCount;
        byte counter = 0;

        if (valueN > limit)
        {
            return;
        }
        limitCount = Math.Sqrt(valueN);
        for (int i = 1; i <= limitCount; i++)
        {
            if (valueN % i == 0)
            {
                counter++;
            }
        }
        Console.Write("{0}", valueN);
        Console.WriteLine(counter == 1 ? " is prime number" : " isn't prime number");
    }
}
