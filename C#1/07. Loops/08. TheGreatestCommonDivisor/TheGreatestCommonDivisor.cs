
// 08.
// Write a program that calculates the greatest common divisor 
// (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).


using System;

class TheGreatestCommonDivisor
{
    static void Main()
    {

        int numberA = 56;
        int numberB = 43;
        int maxNumber;
        int subscore;
        ///////always a>b/////////////
        if (numberA < numberB)
        {
            maxNumber = numberB;
            numberB = numberA;
            numberA = maxNumber;
        }
        ///////calc GCD///////////////
        while (numberB != 0)
        {
            subscore = numberA % numberB;
            numberA = numberB;
            numberB = subscore;
        }
       // Console.WriteLine("Number A = {0}", numberA);
       // Console.WriteLine("Number B = {0}", numberB);
        Console.WriteLine("GCD of A and B = {0}", numberA);
        Console.WriteLine();
    }
}