using System;

class DeclareFiveVariables
{
    static void Main()
    {
        sbyte variable2 = -115;       // range:        -128 - 127
        byte variable1 = 97;          // range:           0 - 255
        short variable3 = -10000;     // range:      -32767 - 32767
        int variable4 = 52130;        // range: -2147483648 - 2147483647
        uint variable5 = 4825932;     // range:           0 - 4294967295
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n", variable1, variable2, variable3, variable4, variable5);
    }       
}

