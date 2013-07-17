// 07.
// Write a program that gets a number n and after that gets 
// more n numbers and calculates and prints their sum. 

using System;


class CalculatesSumOfNumbers
{
    static void Main()
    {
        ConsoleKeyInfo exitKey;
        string strN;
        double n;
        double result = 0;
        bool comparing = false;
        do
        {
            do
            {
                comparing = false;
                Console.WriteLine("Enter number : ");
                if (!(double.TryParse(strN = Console.ReadLine(), out n)))
                {
                    comparing = true;
                    Console.Write("This number is not valid. Enter new number : ");
                }
            } while (comparing == true);

            result = result + n;
            Console.WriteLine("sum  = " + result);
            Console.WriteLine("For exit press Escape");
            exitKey = Console.ReadKey();
        } while (exitKey.Key != ConsoleKey.Escape);

    }
}