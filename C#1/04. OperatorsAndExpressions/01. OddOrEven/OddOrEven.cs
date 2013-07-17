
// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        int varA;
        Console.WriteLine("Input integer.");
        Console.Write("Въведете цяло число. ");
        varA = int.Parse(Console.ReadLine());
        bool resultOfComparing = ((varA % 2) == 0);

        // visualisation of result

        if (resultOfComparing == true)
        {
            Console.WriteLine("The Number {0} is EVEN.", varA);
            Console.WriteLine("Числото {0} е четно.", varA);
        }
        else
        {
            Console.WriteLine("The Number {0} is ODD.", varA);
            Console.WriteLine("Числото {0} е нечетно.", varA);
            Console.WriteLine();
        }
    }
}