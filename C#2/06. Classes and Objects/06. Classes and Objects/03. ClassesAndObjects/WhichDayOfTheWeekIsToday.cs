﻿
// 03.
// Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;

class WhichDayOfTheWeekIsToday
{
    static void Main()
    {         
         Console.WriteLine("Today is " + DateTime.Now.DayOfWeek);
    }
}
