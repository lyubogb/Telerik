
// Write an expression that checks if given point
// (x,  y) is within a circle K(O, 5).

using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write("Enter R=");
        double radius = double.Parse(Console.ReadLine());
        Console.Write("XPoint=");
        double variableXPoint = double.Parse(Console.ReadLine());
        Console.Write("YPoint=");
        double variableYPoint = double.Parse(Console.ReadLine());

        double radiusOfPoint = Math.Sqrt((variableXPoint * variableXPoint) + (variableYPoint * variableYPoint));

        if (radius > radiusOfPoint)
        {
            Console.WriteLine("The point is within the circle");
        }
        else
        {
            Console.WriteLine("The point is outside the circle");
        }
    }
}