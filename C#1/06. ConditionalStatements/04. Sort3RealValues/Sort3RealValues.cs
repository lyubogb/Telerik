
// 04.
// Sort 3 real values in descending order using nested if statements.

using System;
using System.Globalization;
using System.Threading;

class Sort3RealValues
{
    static void Main()
    {
        do
        {
            int firstNumber;
            int seccondNumber;
            int thirdNumber;
            int buffer;
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

            if (firstNumber > seccondNumber)            
            {
                buffer = seccondNumber;
                seccondNumber = firstNumber;
                firstNumber = buffer;
            }
            if (seccondNumber > thirdNumber)
            {
                buffer = thirdNumber;
                thirdNumber = seccondNumber;
                seccondNumber = buffer;
            }
            if (firstNumber > seccondNumber)
            {
                buffer = seccondNumber;
                seccondNumber = firstNumber;
                firstNumber = buffer;
            }

            Console.WriteLine("{2}, {1}, {0}", firstNumber, seccondNumber, thirdNumber);
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
