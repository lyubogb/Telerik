
// Write a boolean expression that returns if the bit at position p 
// (counting from 0) in a given integer number v has value of 1. 
// Example: v=5; p=1  false.

using System;

class ReturnsValueFromBitPosition
{
    static void Main()
    {
        Console.WriteLine(@"
Write a boolean expression that returns if the bit at position p 
(counting from 0) in a given integer number v has value of 1.");

        Console.Write("Enter integer value: ");
        int variable = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());

        ////////////////////////////////////////////////////////////////////////

        int mask = 1 << bitPosition;
        bool resultAfterComparing = ((variable & mask) >> bitPosition) == 1;

        ////////////////////////////////////////////////////////////////////////

        Console.WriteLine("v={0}" + "; p={1}" + "; {2}", variable, bitPosition, resultAfterComparing);

    }
}


