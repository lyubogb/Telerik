
//02.
// Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;
using System.Globalization;
using System.Threading;
 
class CalculatigPOfCircle
{
    static void Main()
    {
        ConsoleKeyInfo exitKey;
        do
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Enter  Radius for calculating P of circle = ");
            string strRadius = Console.ReadLine();
            double radius;
            
            if (double.TryParse(strRadius, out radius))
            {
                Console.WriteLine("Valid number: {0}", radius);
                Console.WriteLine("P = " + (radius * 2 * Math.PI));
                Console.WriteLine("S = " + (radius*radius*Math.PI));
            }
            else
            {
                Console.WriteLine("Invalid number: {0}", strRadius);
            }
            Console.WriteLine("For exit press Escape");
            exitKey = Console.ReadKey();
            Console.WriteLine();
        } while (exitKey.Key != ConsoleKey.Escape);
    }
}