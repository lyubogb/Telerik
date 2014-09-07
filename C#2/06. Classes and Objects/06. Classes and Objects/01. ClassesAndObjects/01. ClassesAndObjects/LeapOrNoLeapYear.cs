
// 01.
// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class LeapOrNoLeapYear
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter year: ");
            int x = int.Parse(Console.ReadLine());
            int y = 12;
            int z = 31;
            DateTime date = new DateTime(x, y, z);
            Console.WriteLine(date.DayOfYear == 366 ? ("The year {0} is Leap!") : ("The year {0} is NOT Leap!"), x);
            // Console.WriteLine(x%4 == 0 ? ("The year {0} is Leap!") : ("The year {0} is NOT Leap!"), x);
        }
    }
}