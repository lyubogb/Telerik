
// We are given integer number n, value v (v=0 or 1) and a position p. 
// Write a sequence of operators that modifies n to hold the value v at 
// the position p from the binary representation of n.
//	Example: n = 5 (00000101), p=3, v=1 --> 13 (00001101)
//	n = 5 (00000101), p=2, v=0 --> 1 (00000001)


using System;

class WriteInBitPosition
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int valueN = int.Parse(Console.ReadLine());
        Console.Write("Enter 0 or 1 for newValueOfBite: ");
        int newValueOfBite = int.Parse(Console.ReadLine());
        Console.Write("Enter bite for changing: ");
        int newBitPosition = int.Parse(Console.ReadLine());
        int mask;
        int result;

        ///////////////////////////////////////////////////////////////

        if (newValueOfBite == 1)
        {
            mask = (1 << newBitPosition);
            result = valueN | mask;
        }
        else
        {
            mask = ~(1 << newBitPosition);
            result = valueN & mask;
        }

        ///////////////////////////////////////////////////////////////

        Console.WriteLine();
        Console.Write("Old N = {0} - ", valueN);
        Console.WriteLine(Convert.ToString(valueN,2).PadLeft(32,'0'));
        Console.WriteLine();
        Console.Write("New N = {0} - ", result);
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}
