
// Write a program that exchanges bits {p, p+1, …, p+k-1) 
// with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.


using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter integer for editing: ");
        uint number = uint.Parse(Console.ReadLine()); // number for editing
        uint buffer1; // Bit from low position
        uint buffer2; // Bit from high position
        uint mask;
        Console.Write("Enter first start bit position: ");
        byte start1 = byte.Parse(Console.ReadLine());
        Console.Write("Enter second start bit position: ");
        byte start2 = byte.Parse(Console.ReadLine());
        Console.Write("Enter interval of bits: ");
        uint bitsIntelval = uint.Parse(Console.ReadLine());
        byte position1; // Low position
        byte position2; // High position

        ///////////////////////////////////////////////////////
        Console.WriteLine();
        Console.WriteLine("Number before editing: {0}", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        for (position1 = start1, position2 = start2; position1 <= position1 + (--bitsIntelval); position1++, position2++)
        {
            ///READING/////////////////////////////////////////
            mask = (uint)(1 << position1);
            buffer1 = ((number & mask) >> position1);
            mask = (uint)1 << position2;
            buffer2 = ((number & mask) >> position2);

            if (buffer2 == 1)
            {
                ///WRITING 1 in the new position //////////////////
                mask = (uint)(1 << position1);
                number = number | mask;
            }
            else
            ///WRITING 0///////////////////////////////////////
            {
                mask = ~((uint)(1 << position1));
                number = number & mask;
            }

            if (buffer1 == 1)
            {
                ///WRITING 1 in the new position //////////////////
                mask = (uint)(1 << position2);
                number = number | mask;
            }
            else
            ///WRITING 0///////////////////////////////////////
            {
                mask = ~((uint)(1 << position2));
                number = number & mask;
            }
        }
        Console.WriteLine("Number after editing: {0}", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

    }
}
