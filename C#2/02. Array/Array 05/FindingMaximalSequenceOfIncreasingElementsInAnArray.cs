// 05.
// Write a program that finds the maximal 
// increasing sequence in an array. 
// Example: {3, 2, 3, 4, 2, 2, 4} --> {2, 3, 4}.


using System;

class FindingMaximalSequenceOfIncreasingElementsInAnArray
{
    static void Main()
    {
        int x = 7;
        int[] array1 = new int[x];
        int number = 0;
        int counter = 0;
        int maxCounter = 0;
        string stringForPrint = null;
        //////////////////////////////////////////////////////
        Console.WriteLine(@"
Write a program that finds the maximal 
increasing sequence in an array. 
Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.");
        Console.WriteLine(new string('=', 50));
        Console.WriteLine("How members you wont to be have in the array.");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter members of the array");
        //////////////////////////////////////////////////////
        for (int i = 0; i < x; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }
        //////////////////////////////////////////////////////
        for (int i = 1; i < x; i++)
        {
            if (array1[i] - 1 == array1[i - 1])
            {
                counter++;
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    number = array1[i];
                }
            }
            else
            {
                counter = 0;
            }
        }
        //////////////////////////////////////////////////////
        for (int i = maxCounter; i >= 0; i--)
        {
            stringForPrint += (number - i) + " ";
        }
        //////////////////////////////////////////////////////
        Console.WriteLine(new string('=', 50));
        Console.Write("Maximal increasing sequence is ");
        Console.WriteLine(stringForPrint);
    }
}
