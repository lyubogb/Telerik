
// 08.
// Write a program that, depending on the user's choice inputs int, 
// double or string variable. If the variable is integer or double, 
// increases it with 1. If the variable is string, appends "*" at its end. 
// The program must show the value of that variable as a console output. 
// Use switch statement.

using System;
using System.Globalization;
using System.Threading;

class PrintsObject
{
    static void Main()
    {
        //////////////////////////////////////////////////////////////////////
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //////////////////////////////////////////////////////////////////////
        do
        {
            Console.Write("Enter value with integer, double or string : ");
            string inValue = Console.ReadLine();
            double doubleResult;
            int intResult;
            bool compaeBite = double.TryParse(inValue, out doubleResult);
            //////////////////////////////////////////////////////////////////////
            switch (compaeBite)
            {
                case true:
                    {
                        switch (compaeBite = int.TryParse(inValue, out intResult))
                        {
                            case true:
                                {               //int
                                    Console.WriteLine("Number {1} is int snd result is = {0}", ++intResult, inValue);
                                    break;
                                }
                            case false:
                                {               //double
                                    Console.WriteLine("Number {1} is int snd result is = {0}", ++doubleResult, inValue);
                                    break;
                                }                            
                        }
                        break;
                    }
                case false:             // string
                    {
                        Console.WriteLine("The string {1} is int snd result is = {0}", inValue + "*", inValue);
                        break;
                    }
            }
        } while (true);

    }
}