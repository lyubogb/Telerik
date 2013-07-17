
// Write an expression that extracts from a given integer i 
// the value of a given bit number b. Example: i=5; b=2 --> value=1.


using System;

class ReturnsValueFromPos
{
    static void Main()
    {
        Console.Write("Enter integer value: ");
        int variable = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(variable, 2).PadLeft(32, '0'));
        Console.Write("Enter bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());

        ////////////////////////////////////////////////////////////////////////

        int mask = 1 << bitPosition;
        int resultAfterComparing = (variable & mask) >> bitPosition;

        ////////////////////////////////////////////////////////////////////////

        Console.WriteLine("Valu on this position is {0}", resultAfterComparing);
    }
}