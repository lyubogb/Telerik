
// 14. 
// * Write a program that reads a positive integer number N (N < 20) 
// from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.


using System;

class SpiralMatrix
{
    static void Main()
    {
        do
        {
            int numberN;
            bool xxx;
            do
            {
                Console.Write("Enter integer number N = ");
                xxx = int.TryParse(Console.ReadLine(), out numberN);
                if (numberN >= 20 || numberN < 0)
                {
                    Console.WriteLine("Number N must by < 20");
                    xxx = false;
                }
            } while (xxx == false);

            int xMin = 5;
            int yMin = 5;
            int xMax;
            int yMax;
            int numberMax;
            int pNumber = 1;
            int stepX = 3;
            int stepY = 2;
            int cursorPositionX;
            int cursorPositionY;

            if (numberN >= 10)
            {
                stepX++;
                stepY++;
            }
            Console.WindowWidth = numberN * stepX + 14;
            Console.WindowHeight = numberN * stepY + 10;
            Console.Clear();
            xMax = numberN * stepX + xMin;
            yMax = (numberN - 1) * stepY + yMin;
            numberMax = (numberN * numberN);
            cursorPositionX = Console.CursorLeft + xMin;
            cursorPositionY = Console.CursorTop + yMin;

            do
            {

                while (cursorPositionX < xMax)
                {
                    cursorPositionX += stepX;
                    Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                    Console.Write("{0,-2}", pNumber);
                    pNumber++;
                }
                yMin += stepY;

                while (cursorPositionY < yMax)
                {
                    cursorPositionY += stepY;
                    Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                    Console.Write("{0,-2}", pNumber);
                    pNumber++;
                }
                xMin += stepX;
                while (cursorPositionX > xMin)
                {
                    cursorPositionX -= stepX;
                    Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                    Console.Write("{0,-2}", pNumber);
                    pNumber++;
                }
                yMax -= stepY;
                while (cursorPositionY > yMin)
                {
                    cursorPositionY -= stepY;
                    Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                    Console.Write("{0,-2}", pNumber);
                    pNumber++;
                }
                xMax -= stepX;
            } while (pNumber <= numberMax);
            Console.SetCursorPosition(0, 0);
            //Console.ReadLine(
        } while (true);
    }
}
