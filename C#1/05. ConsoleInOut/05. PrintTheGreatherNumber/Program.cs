
// 05.
// Write a program that gets two numbers from the console and 
// prints the greater of them. Don’t use if statements.

using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        string strFirstNumber;
        string strSeccondNumbers;
        double a;
        double b;
        bool comparing;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        ConsoleKeyInfo exitKey;

        do
        {
            Console.WriteLine("Program that prints the greater of both integer numbers.\n\n");
            // first number a
            do
            {
                comparing = false;
                Console.Write("Enter number A = ");
                if (double.TryParse(strFirstNumber = Console.ReadLine(), out a))
                {
                    Console.WriteLine();
                    //Console.WriteLine("Number {0} is valid\n", a);
                }
                else
                {
                    comparing = true;
                    Console.WriteLine("Number {0} is invalid\n", strFirstNumber);
                }
            } while (comparing == true);

            // first number b
            do
            {
                comparing = false;
                Console.Write("Enter number B = ");
                if (double.TryParse(strSeccondNumbers = Console.ReadLine(), out b))
                {
                    Console.WriteLine();
                    //Console.WriteLine("Number {0} is valid\n", b);
                }
                else
                {
                    comparing = true;
                    Console.WriteLine("Number {0} is invalid\n", strSeccondNumbers);
                }
            } while (comparing == true);

            ///////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine();
            Console.WriteLine("Greather of both numbers is {0}", Math.Max(a,b));

            ///////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine();
            Console.WriteLine("Enter Escape for exit or any key for continue.");
            exitKey = Console.ReadKey();

        } while ((exitKey.Key != ConsoleKey.Escape));

    }
}