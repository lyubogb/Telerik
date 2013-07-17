
// 02.
// Write a program that shows the sign of the product of three real
// numbers without calculating it. Use a sequence of if statements.

using System;
using System.Globalization;
using System.Threading;

class SignOfTheProductOfRealNumbers
{
    static void Main()
    {
        do
        {
            double firstNumber;
            double seccondNumber;
            double thirdNumber;

            Console.Write("Enter first number = ");
            firstNumber = Input();
            Console.Write("Enter seccond number = ");
            seccondNumber = Input();
            Console.Write("Enter third number = ");
            thirdNumber = Input();


            double product = firstNumber * seccondNumber * thirdNumber;

            if ((product - (Math.Abs(product))) == 0)
            {
                Console.WriteLine("Product is positive number.");
            }
            else
            {
                Console.WriteLine("Product is negative number.");
            }
            Console.WriteLine();

        } while (true);

    }


    static double Input() // entering text from the console
    {
        string strBuffer;
        double doubleBuffer;

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        do
        {
            int positionY;
            int positionX;
            positionX = Console.CursorLeft;
            positionY = Console.CursorTop;

            Console.ForegroundColor = ConsoleColor.Blue;
            if (!(double.TryParse(strBuffer = Console.ReadLine(), out doubleBuffer)))
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