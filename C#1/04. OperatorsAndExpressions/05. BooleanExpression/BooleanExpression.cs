
// Write a boolean expression for finding if the bit 3
// (counting from 0) of a given integer is 1 or 0.

using System;

class BooleanExpression
{
    static void Main()
    {
        uint variable;
        byte biteNumber;
        uint mask = 1;

        Console.WriteLine("Input short digit.");
        Console.WriteLine("Въведете short число.");
        variable = uint.Parse(Console.ReadLine());
        Console.WriteLine("Which bit you want to be read.");
        Console.WriteLine("Кой бит желаете да бъде прочетен");
        biteNumber = byte.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(mask, 2).PadLeft(8, '0'));
        mask = mask << biteNumber;
        Console.WriteLine("{000000000}", mask);
        uint result = variable & mask;
        result = result >> biteNumber;
        Console.WriteLine("This bit is: {0}", result);
    }
}
