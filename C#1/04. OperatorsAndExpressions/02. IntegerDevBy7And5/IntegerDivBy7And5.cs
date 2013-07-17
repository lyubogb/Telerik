
// Write a boolean expression that checks for given integer if it can be divided 
// (without remainder) by 7 and 5 in the same time.

using System;

class IntegerDivBy7And5
{
    static void Main()
    {
        int varA;
        Console.WriteLine("Input integer.");
        Console.WriteLine("Въведете цяло число.");
        varA = int.Parse(Console.ReadLine());

        if (((varA % 7) == 0) && ((varA % 5) == 0))
        {
            Console.WriteLine("The Number {0} can by divided by 7 and 5 in the same time.", varA);
            Console.WriteLine("Числото {0} може да се дели едновременно на 7 и на 5.", varA);

        }
        else
        {
            Console.WriteLine("The Number {0} can't by divided by 7 and 5 in the same time.", varA);
            Console.WriteLine("Числото {0} не може да се дели едновременно на 7 и на 5.", varA);
            Console.WriteLine();
        }
    }
}
