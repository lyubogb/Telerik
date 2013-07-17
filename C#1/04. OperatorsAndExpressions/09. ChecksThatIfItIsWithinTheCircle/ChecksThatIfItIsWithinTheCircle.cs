
// Write an expression that checks for given point (x, y) if it is within 
// the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class ChecksThatIfItIsWithinTheCircle
{
    static void Main()
    {
        // Parameters of point A //////////////////////////////////////

        Console.Write("Enter koordinae of point A  X : ");
        int pointAX = int.Parse(Console.ReadLine());
        Console.Write("Enter koordinae of point A  Y : ");
        int pointAY = int.Parse(Console.ReadLine());
        
        // Parameters of rectangle ////////////////////////////////////
        /*
        Console.Write("Enter koordinae of LeftTop point X : ");
        int rectangleTopLeftX = int.Parse(Console.ReadLine());
        Console.Write("Enter koordinae of LeftTop point Y : ");
        int rectangleTopLeftY = int.Parse(Console.ReadLine());
        Console.Write("Enter with of rectangle L  X : ");
        int rectangleL = int.Parse(Console.ReadLine());
        Console.Write("Enter high of rectangle H  X : ");
        int rectangleH = int.Parse(Console.ReadLine()); 
        */
        // Parameters of circle ///////////////////////////////////////
        /*
        Console.Write("Enter coordinate X of circles centre : ");
        int cirklesCentreX = int.Parse(Console.ReadLine());
        Console.Write("Enter coordinate Y of circles centre : ");
        int cirklesCentreY = int.Parse(Console.ReadLine());
        Console.Write("Enter circles radius : ");
        int cirklesRadius = int.Parse(Console.ReadLine()); 
        */
        ///////////////////////////////////////////////////////////////

        // Parameters of rectangle ////////////////////////////////////

        int rectangleTopLeftX = 1;
        int rectangleTopLeftY = -1;
        int rectangleL = 6;
        int rectangleH = 2;

        // Parameters of circle ///////////////////////////////////////

        int cirklesCentreX = 1;
        int cirklesCentreY = 1;
        int cirklesRadius = 3;

        int newPointX = pointAX - cirklesCentreX;
        int newPointY = pointAY - cirklesCentreY;
        int pointAR = (newPointX * newPointX) + (newPointY * newPointY);
        int cirklesR = (cirklesRadius*cirklesRadius);

        bool pointAInCircle = (cirklesR > pointAR);
        bool pointAInRectangularInHorizontal = (pointAX >= rectangleTopLeftX && pointAX <= (rectangleTopLeftX + rectangleL));
        bool pointAInRectangularInVertical = (pointAY >= rectangleTopLeftY && pointAY <= rectangleTopLeftY + rectangleH);
        bool pointAInCircleAndRectangle = (pointAInCircle && pointAInRectangularInHorizontal && pointAInRectangularInVertical);

        if (pointAInCircleAndRectangle == true)
        {
            Console.WriteLine("The point is within of the figures");
        }
        else
        {
            Console.WriteLine("The point is outside of figures");
        }
        
    }
}

