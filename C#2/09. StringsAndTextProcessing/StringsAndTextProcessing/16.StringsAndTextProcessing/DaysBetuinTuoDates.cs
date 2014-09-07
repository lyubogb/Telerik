
// 16.
// Write a program that reads two dates in the format: 
// day.month.year and calculates the number of days between them. 
// Example:
// Enter the first date: 27.02.2006
// Enter the second date: 3.03.2004
// Distance: 4 days

using System;
using System.Globalization;

class DaysBetuinTuoDates
{
    static void Main()
    {
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.m.yyyy", CultureInfo.InvariantCulture);
        DateTime firstDatePrim = DateTime.Parse(firstDate.ToString("d.m"));

        DateTime secondtDate = DateTime.ParseExact(Console.ReadLine(), "d.m.yyyy", CultureInfo.InvariantCulture);
        DateTime secondtDatePrim = DateTime.Parse(secondtDate.ToString("d.m"));

        Console.WriteLine((secondtDatePrim > firstDatePrim) ? "Distance {0} days" : "Distance {} days", (secondtDatePrim - firstDatePrim).Days, (firstDatePrim - secondtDatePrim).Days);
    }
}