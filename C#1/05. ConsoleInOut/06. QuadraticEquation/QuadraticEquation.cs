
// 06. 
// Write a program that reads the coefficients a, b and c 
// of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;
using System.Globalization;
using System.Threading;



class Program
{
    static void Main()
    {
        string strA;
        string strB;
        string strC;
        double a;
        double b;
        double c;
        double D;
        double X1;
        double X2;
        bool comparing;

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        ConsoleKeyInfo exitKay;

        do
        {
            Console.WriteLine("Program that solves quadratic equation ax2+bx+c=0\n\n");
            // first number a
            do
            {
                comparing = false;
                Console.Write("Enter coefficient a = ");
                if (double.TryParse(strA = Console.ReadLine(), out a))
                {
                    Console.WriteLine("Number {0} is valid\n", a);
                }
                else
                {
                    comparing = true;
                    Console.WriteLine("Number {0} is invalid\n", strA);
                }
            } while (comparing == true);

            // first number b
            do
            {
                comparing = false;
                Console.Write("Enter coefficient b = ");
                if (double.TryParse(strB = Console.ReadLine(), out b))
                {
                    Console.WriteLine("Number {0} is valid\n", b);
                }
                else
                {
                    comparing = true;
                    Console.WriteLine("Number {0} is invalid\n", strB);
                }
            } while (comparing == true);

            // first number c
            do
            {
                comparing = false;
                Console.Write("Enter coefficient c = ");
                if (double.TryParse(strC = Console.ReadLine(), out c))
                {
                    Console.WriteLine("Number {0} is valid\n", c);
                }
                else
                {
                    comparing = true;
                    Console.WriteLine("Number {0} is invalid\n", strC);
                }
            } while (comparing == true);


            /////////////////////CALCULATING/////////////////////////////////////////////

            D = (b * b) - (4 * a * c);

            if (a == 0)
            {
                X1 = (-1 * c) / b;
                Console.WriteLine("Line equation of type bX+c=0");
                Console.WriteLine("X = " + X1);
            }

            if (a != 0 && D > 0)
            {
                X1 = ((-1 * b) + Math.Sqrt(D)) / 2;
                X2 = ((-1 * b) - Math.Sqrt(D)) / 2;
                Console.WriteLine("X1 = {0}\nX2 = {1}", X1, X2);
            }

            if (a != 0 && D < 0)
            {
                Console.WriteLine("Line equation haven't real answers");
            }

            if (a != 0 && D == 0)
            {
                X1 = X2 = (-1 * b) / (2 * a);
                Console.WriteLine("X1 = {0}\nX2 = {1}", X1, X2);
            }

            Console.WriteLine();
            Console.WriteLine("Enter Escape for exit or anycay for continu.");
            exitKay = Console.ReadKey();

        } while ((exitKay.Key != ConsoleKey.Escape));

        /////////////////////////////////////////////////////////////////////////////

    }
}