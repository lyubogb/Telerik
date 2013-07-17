
// Write an expression that calculates rectangle’s
// area by given width and height.

using System;

class CalculatesArea
{
    static void Main()
    {
        double rectanglesWidth;
        double rectanglesHeight;
        double area;
        //////////////////////////////////////////////////
        Console.WriteLine("Input width of the rectangle.");
        rectanglesWidth = double.Parse(Console.ReadLine());
        Console.WriteLine("Input height of the rectangle.");
        rectanglesHeight = double.Parse(Console.ReadLine());
        area = rectanglesWidth * rectanglesHeight;
        ///////////////////////////////////////////////////
        Console.WriteLine("Rektangle's area is {0}", area);
    }
}