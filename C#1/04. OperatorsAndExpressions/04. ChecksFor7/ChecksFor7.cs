
// Write an expression that checks for given integer if
// its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class ChecksFor7
{
    static void Main()
    {
        int digit;
        int digitForComparing;

        Console.WriteLine("Input integer.");
        Console.WriteLine("Въведете цяло число.");
        digit = int.Parse(Console.ReadLine());
        Console.WriteLine("Input integer for searching.");
        Console.WriteLine("Въведете числото за търсене.");
        digitForComparing = int.Parse(Console.ReadLine());

        if (((digit / 100) % 10) == digitForComparing)
        {
            Console.WriteLine("In this number have integer {0} for third digit", digitForComparing);
        }
        else
        {
            Console.WriteLine("In this number havn't integer {0} for third digit", digitForComparing);
        }
    }
}
