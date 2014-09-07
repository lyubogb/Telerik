
// 04.
// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it; 
// Three sides; 
// Two sides and an angle between them. Use System.Math.


using System;

class SurfaceOfTriangle
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine(@"
Choice method for calculate the surface of a triangle by given:
1 - Side and an altitude to it 
2 - Three sides; 
3 - Two sides and an angle between them. 
");
            double a = 0;
            double b = 0;
            double c = 0;
            double h = 0;
            double alpha = 0;
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Enter A = ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Enter Ha = ");
                        h = double.Parse(Console.ReadLine());
                        Console.WriteLine(GetAreaWithAltitude(a, h));
                        break;
                    }

                case 2:
                    {
                        Console.Write("Enter A = ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Enter B = ");
                        b = double.Parse(Console.ReadLine());
                        Console.Write("Enter C = ");
                        c = double.Parse(Console.ReadLine());
                        Console.WriteLine(GetAreaWithThreeSides(a, b, c));
                        break;
                    }

                case 3:
                    {
                        Console.Write("Enter A = ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Enter B = ");
                        b = double.Parse(Console.ReadLine());
                        Console.Write("Enter Alpha = ");
                        alpha = double.Parse(Console.ReadLine());
                        Console.WriteLine(GetAreaWithAngle(a, b, alpha));
                        break;
                    }
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }

    static double GetAreaWithAltitude(double a, double h)
    {
        return (a * h) / 2;
    }
    static double GetAreaWithThreeSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2;

        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    static double GetAreaWithAngle(double a, double b, double alpha)
    {
        double alphaRad = Math.Sin(alpha * Math.PI / 180);
        return (a * b * alphaRad) / 2;
    }
}
