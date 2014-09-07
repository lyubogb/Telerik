
// 01.
// Write a program that reads an integer number and calculates and prints its square root.
// If the number is invalid or negative, print "Invalid number". 
// In all cases finally print "Good bye". Use try-catch-finally.

using System;

class SQRT
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter Your integer number. --> ");
            uint newNumber = 0;
            try
            {
                newNumber = uint.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(newNumber));
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid number! (Invalid format)");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Invalid number! (Out of range)");
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Invalid number! (Empty string)");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}