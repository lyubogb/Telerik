using System;

class ASCII
{
    static void Main()
    {
        int count;
        char symbol = Convert.ToChar(0);

        for (count = 0; count < 255; count++)
        {
            symbol = Convert.ToChar(count);
            Console.WriteLine(symbol);
        }
    }
}
