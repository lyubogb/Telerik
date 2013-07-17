
// Write an expression that calculates trapezoid's area
// by given sides a and b and height h.

using System;

class TrapezoidsArea
{
    static void Main()
    {
        Console.Write("Enter side A: ");
        int sideA = int.Parse(Console.ReadLine());
        Console.Write("Enter side B: ");
        int sideB = int.Parse(Console.ReadLine());
        Console.Write("Enter h: ");
        int high = int.Parse(Console.ReadLine());
        int trapecoidArea;

        ////////////////////////////////////////////////////////

        trapecoidArea = high * ((sideA + sideB) / 2);

        ////////////////////////////////////////////////////////

        Console.WriteLine("Trapecoid area is {0}", trapecoidArea);
    }
}

