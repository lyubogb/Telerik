
// 04.
// Write a program that reads two positive integer numbers 
// and prints how many numbers p exist between them such that 
//the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
////////////short model//////////////////////////////////////////////////////////////////////////////

using System;
using System.Globalization;
using System.Threading;

class printAnyNumbers
{
    static void Main()
    {
        int counter = 0;
        bool comparing;
        string strFirstNumber;
        string strSecondNumber;
        int firstNumber;
        int secondNumber;

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        ConsoleKeyInfo exitKay;
        do
        {
            do
            {
                comparing = false;
                Console.Write("Enter low lewel : ");
                if (int.TryParse(strFirstNumber = Console.ReadLine(), out firstNumber))
                {
                    Console.WriteLine("Number {0} is valid\n", firstNumber);
                }
                else
                {
                    comparing = true;
                    Console.WriteLine("Number {0} is invalid\n", strFirstNumber);
                }
            } while (comparing == true);

            do
            {
                comparing = false;
                Console.Write("Enter high lewel : ");
                if (int.TryParse(strSecondNumber = Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("Number {0} is valid\n", secondNumber);
                }
                else
                {
                    comparing = true;
                    Console.WriteLine("Number {0} is invalid\n", strSecondNumber);
                }
            } while (comparing == true || !(secondNumber > firstNumber));


            while (firstNumber <= secondNumber)
            {
                if ((firstNumber % 5) == 0)
                {
                    counter++;
                }
                firstNumber++;
            }
            Console.WriteLine("Numbers between levels that can divide by 5 are {0}", counter);
            Console.WriteLine();
            Console.WriteLine("Enter Escape for exit or anycay for continu.");
            exitKay = Console.ReadKey();

        } while ((exitKay.Key != ConsoleKey.Escape));
    }
}

