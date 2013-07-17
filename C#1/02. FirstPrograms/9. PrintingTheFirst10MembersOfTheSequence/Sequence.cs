using System;

class Sequence
{
    static void Main()
    {
        int startNumber = 2;            // само положителни числа                  // Only positive numbers
        int members = 10;               // брой членове                            // Number of members
        int step = 1;                   // стъпка                                  // Step
        bool simmetry = true;           // симетрично на 0-та или само положителни // Simetrical of the 0 or only positive
        int variable = 0;               //                                         //
        int result = 0;                 // Стойност за отпечатване                 // Print value
        int x = startNumber + members * step;

        if (startNumber >= 0)
        {
            result = -1;
        }
        else
        {
            result = 1;
        }
        for (int I = startNumber; I < (x); I = I + step)
        {
            if (simmetry == true && result>0)
            {
                variable = -1 ;
            }
            else
            {
                variable = 1 ;
            }
            result = variable*I;
            Console.WriteLine("{0,4:D}", result);
        }
    }
}
