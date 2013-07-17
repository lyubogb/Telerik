
// 01.
// Write an if statement that examines two integer variables and exchanges 
// their values if the first one is greater than the second one.

using System;
using System.Globalization;
using System.Threading;

class TheGreaterNumber
{
    static void Main()
    {
        do
        {
            double a;
            double b;
            double buffer;
            Console.Write("Enter first number   = ");
            a = Input();
            Console.Write("Enter seccond number = ");
            b = Input();

            /////////////////////////////////////////////////////////////////

            if (a > b)
            {
                buffer = b;
                b = a;
                a = buffer;
            }

            /////////////////////////////////////////////////////////////////

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==========================================");
            Console.WriteLine("first number   = {0}", a);
            Console.WriteLine("seccond number = {0}", b);
            Console.WriteLine();
            Console.ResetColor();
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

