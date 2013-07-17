
// Write a program that exchanges bits 3, 4 and 5 with 
// bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter integer value: ");
        int number = int.Parse(Console.ReadLine()); // number for editing
        int buffer1; // Bit from low position
        int buffer2; // Bit from high position
        int mask;
        int position1 = 3; // Low position
        int position2 = 24; // High position

        ///////////////////////////////////////////////////////////

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        for (position1 = 3, position2 = 24; position1 <= 5; position1++, position2++)
        {
            ///READING/////////////////////////////////////////////
            mask = 1 << position1;
            buffer1 = ((number & mask) >> position1);
            mask = 1 << position2;
            buffer2 = ((number & mask) >> position2);

                       if (buffer2 == 1)
            {
                ///WRITING 1 in the new position //////////////////
                mask = 1 << position1;
                number = number | mask;
            }
            else
            ///WRITING 0///////////////////////////////////////////
            {
                mask = ~(1 << position1);
                number = number & mask;
            }

            if (buffer1 == 1)
            {
                ///WRITING 1 in the new position //////////////////
                mask = 1 << position2;
                number = number | mask;
            }
            else
            ///WRITING 0///////////////////////////////////////////
            {
                mask = ~(1 << position2);
                number = number & mask;
            }
        }
        Console.WriteLine("last value is : {0}", number);
        Console.WriteLine(Convert.ToString(number,2).PadLeft(32,'0'));
    }
}
