// 02.
// Write a program that finds the maximal 
// sequence of equal elements in an array.
// Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} --> {2, 2, 2}.

using System;

class FindingMaximalSequenceOfEqualElementsInAnArray 
{
    static void Main()
    {
        int x = 10;
        int[] array1 = new int[x];
        int number = 0;
        int lastMaxNumber = 0;
        int counter = 1;
        int maxCounter = 0;

        Console.WriteLine(@"
Write a program that finds the maximal sequence 
      of equal elements in an array.
");
        Console.WriteLine(new string ('=',50));
        Console.WriteLine("Enter members of the array");

        for (int i = 0; i < x; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < x; i++)
        {
            if (array1[i] == array1[i - 1])
            {
                number = array1[i];
                counter++;

                if (maxCounter <= counter)    // with <= for last entered combination, but only < for first
                {
                    lastMaxNumber = number;
                    maxCounter = counter;
                }
            }
            else
            {
                number = array1[i];
                counter = 1;
            }
        }
        Console.WriteLine(new string('=', 50));
        for (int i = 0; i < maxCounter; i++)
        {
            Console.Write("{0} ", lastMaxNumber);
        }
        Console.WriteLine();
    }
}
