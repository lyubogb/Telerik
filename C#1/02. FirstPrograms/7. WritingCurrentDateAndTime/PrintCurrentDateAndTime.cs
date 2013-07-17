using System;

class PrintCurrentDateAndTime
{
    static void Main()
    {
        Console.WriteLine("Днес е {0:D}\n"+"Часът сега е {0:T}\n", DateTime.Now);
    }
}
