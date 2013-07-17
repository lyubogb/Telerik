
//01.
// Write a program that reads 3 integer numbers from the console and prints their sum.

using System;
using System.Globalization;
using System.Threading;

//short variant//////////////////////////////////////////////////////////
//
//class PrintsSum
//{
//    static void Main()
//    {
//        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
//        int a = int.Parse(Console.ReadLine());
//        int b = int.Parse(Console.ReadLine());
//        int c = int.Parse(Console.ReadLine());
//        Console.WriteLine(a + b + c);
//    }
//}

// smart variant////////////////////////////////////////////////////////
class Temporary
{
    static void Main()
    {
        ConsoleKeyInfo exitKay;
        do
        {
            // first number
            string strFirstName;
            int firstNumber;
            // seccond number
            string strSeccondName;
            int seccondNumber;
            // third number
            string strThirdName;
            int thirdNumber;
            bool comparing;

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            ////////////////////////////////////////////////////////////////////////////////
            // first number
            do
            {
                comparing = false;
                Console.Write("Enter first integer number   = ");
                if (int.TryParse(strFirstName = Console.ReadLine(), out firstNumber))
                {
                    Console.WriteLine("Valid number: {0}", strFirstName);
                }
                else
                {
                    comparing = true;
                    Console.WriteLine("Invalid number: {0}", strFirstName);
                }
            } while (comparing == true);


            // seccon number
            do
            {
                comparing = false;
                Console.Write("Enter seccond integer number = ");
                if (int.TryParse(strSeccondName = Console.ReadLine(), out seccondNumber))
                {
                    Console.WriteLine("Valid number: {0}", strSeccondName);
                }
                else
                {
                    comparing = true;
                    Console.WriteLine("Invalid number: {0}", strSeccondName);
                }
            } while (comparing == true);


            // third number
            do
            {
                comparing = false;
                Console.Write("Enter third integer number   = ");
                if (int.TryParse(strThirdName = Console.ReadLine(), out thirdNumber))
                {
                    Console.WriteLine("Valid number: {0}", strThirdName);
                }
                else
                {
                    comparing = true;
                    Console.WriteLine("Invalid number: {0}", strThirdName);
                }

            } while (comparing == true);

            ////////////////////////////////////////////////////////////////////////////////    
            Console.WriteLine();
            Console.WriteLine(firstNumber + " + " + seccondNumber + " + " + thirdNumber + " = " + (firstNumber + seccondNumber + thirdNumber));

            ////////////////////////////////////////////////////////////////////////////////

            // shortcut for exit

            Console.WriteLine();
            Console.WriteLine("Enter Escape for exit or any key for continue.");
            exitKay = Console.ReadKey();

        } while ((exitKay.Key != ConsoleKey.Escape));

    }
}
