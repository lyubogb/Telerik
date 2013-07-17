
// 03.
// Write a program that finds the biggest of three
// integers using nested if statements.

using System;
using System.Globalization;
using System.Threading;

class FindsTheBiggestOfThreeIntegers
{
    static void Main()
    {
        do
        {
            int firstNumber;
            int seccondNumber;
            int thirdNumber;
            //////////////////////////////////////////////////////////////////////////
            Console.Write("Enter first number = ");
            firstNumber = Input();
            Console.Write("Enter seccond number = ");
            seccondNumber = Input();
            Console.Write("Enter third number = ");
            thirdNumber = Input();
            Console.WriteLine();
            //////////////////////////////////////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.Green;
            if (firstNumber != seccondNumber || seccondNumber != thirdNumber)
            {
                if (firstNumber > seccondNumber)            
                {
                    if (firstNumber > thirdNumber)          
                    {
                        Console.WriteLine("The first number is greater.");
                    }
                    else
                    {
                        Console.WriteLine("The third number is greater.");
                    }
                }
                else
                {
                    if (seccondNumber > thirdNumber)
                    {
                        Console.WriteLine("The seccond number is greater.");
                    }
                    else
                    {
                        Console.WriteLine("The third number is greater.");
                    }
                }
            }
            //////////////////////////////////////////////////////////////////////////
            if (firstNumber == seccondNumber && seccondNumber == thirdNumber)
            {
                Console.WriteLine("The first, seccond and third numbers are equal.");
            }
            else
            {

                if (firstNumber == seccondNumber)
                {
                    Console.WriteLine("The first and seccond numbers are equal.");
                }
                if (firstNumber == thirdNumber)
                {
                    Console.WriteLine("The first and third numbers are equal.");
                }
                if ((firstNumber != seccondNumber) || (firstNumber != thirdNumber))
                {
                    if (seccondNumber == thirdNumber)
                    {
                        Console.WriteLine("The seccond and third numbers are equal.");
                    }
                }
            }
            Console.WriteLine();
            Console.ResetColor();
        } while (true);

    }

    static int Input() // entering text from the console
    {
        string strBuffer;
        int doubleBuffer;

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        do
        {
            int positionY;
            int positionX;
            positionX = Console.CursorLeft;
            positionY = Console.CursorTop;

            Console.ForegroundColor = ConsoleColor.Blue;
            if (!(int.TryParse(strBuffer = Console.ReadLine(), out doubleBuffer)))
            {
                Console.Write("This number is faulty. Enter new number.");
                Console.SetCursorPosition(positionX, positionY);
                Console.Write("                                        ");
                Console.SetCursorPosition(positionX, positionY);
            }
            else
            {
                Console.SetCursorPosition(0, ++positionY);
                Console.Write("                                                                          \r");
                Console.ResetColor();
                return doubleBuffer;
            }
        } while (true);
    }
}