
// 17.
// Write a program that reads a date and time given in the format: 
// day.month.year hour:minute:second and prints the date and time 
// after 6 hours and 30 minutes (in the same format) along with 
// the day of week in Bulgarian.

using System;
using System.Globalization;

class DateAndTime
{
    static void Main()
    {
        Console.WriteLine("Please enter the date and time (dd.mm.yyyy hh:mm:ss): ");
        DateTime date = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        date = date.AddHours(6.5);
        Console.WriteLine(date.ToString("HH:mm:ss dddd", new CultureInfo("bg-BG")));
    }
}