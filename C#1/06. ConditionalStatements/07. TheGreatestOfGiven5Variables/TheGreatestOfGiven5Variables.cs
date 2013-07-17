
// 07.
// Write a program that finds the greatest of given 5 variables.

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
            int fourthlyNumber;
            int fifthNumber;
            int biggestNumber = 0;
            //////////////////////////////////////////////////////////////////////////
            Console.Write("Enter first number = ");
            firstNumber = Input();
            Console.Write("Enter seccond number = ");
            seccondNumber = Input();
            Console.Write("Enter third number = ");
            thirdNumber = Input();
            Console.Write("Enter fourthly number = ");
            fourthlyNumber = Input();
            Console.Write("Enter fifth number = ");
            fifthNumber = Input();
            Console.WriteLine();
            //////////////////////////////////////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.Green;
            biggestNumber = Math.Max(firstNumber, seccondNumber);
            biggestNumber = Math.Max(biggestNumber, thirdNumber);
            biggestNumber = Math.Max(biggestNumber, fourthlyNumber);
            biggestNumber = Math.Max(biggestNumber, fifthNumber);
            //////////////////////////////////////////////////////////////////////////
            Console.WriteLine("The biggest number is {0}", biggestNumber);
            Console.WriteLine();
            Console.ResetColor();
        } while (true);

    }

    static int Input()               // entering text from the console
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