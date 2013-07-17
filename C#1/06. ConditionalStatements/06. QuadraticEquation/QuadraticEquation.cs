
// 06.
// Write a program that enters the coefficients a, b and c of a quadratic equation
//		a*x2 + b*x + c = 0
// and calculates and prints its real roots. 
// Note that quadratic equations may have 0, 1 or 2 real roots.

using System;
using System.Globalization;
using System.Threading;

class QuadraticEquation
{
    static void Main()
    {
        double coefA;
        double coefB;
        double coefC;
        double D;
        double X1;
        double K2;

        do
        {

            //////////////////////////////////////////////////////

            Console.WriteLine("Program for calculate of ax2 + bx + c = 0");
            Console.WriteLine("=========================================");

            //////////////////////////////////////////////////////

            Console.Write("Enter coefficient A = ");
            coefA = Input();
            Console.Write("Enter coefficient B = ");
            coefB = Input();
            Console.Write("Enter coefficient C = ");
            coefC = Input();



            D = (coefB * coefB) - (4 * coefA * coefC);

            X1 = (((-1 * coefB) + (Math.Sqrt(D))) / (2 * coefA));
            K2 = (((-1 * coefB) - (Math.Sqrt(D))) / (2 * coefA));

            Console.WriteLine("=========================================");

            if (D < 0)
            {
                Console.WriteLine("Equation hesn't real roots");
            }
            if (D == 0)
            {
                Console.WriteLine("Roots are : X1 = X2 = {0}", X1);
            }
            if (D > 0)
            {
                Console.WriteLine("Roots are : X1 = {0}; X2 = {1}", X1, K2);
            }
            Console.WriteLine();
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