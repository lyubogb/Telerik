
// 05.
// Write a method that calculates the number of workdays between today and given date, 
// passed as parameter. Consider that workdays are all days from Monday to Friday except 
// a fixed list of public holidays specified preliminary as array.

using System;

class NumberOfWorkdays
{
    static void Main()
    {
        int intervalOfDays = 0;
        int countWorkDays = 0;
        bool isHoliday = false;
        DateTime[] holidays = { 
                new DateTime ( 2010, 05, 01 ),
                new DateTime ( 2010, 05, 24 ),
                new DateTime ( 2010, 12, 31 ),
                new DateTime ( 2011, 05, 01 ),
                new DateTime ( 2011, 05, 24 ),
                new DateTime ( 2011, 12, 31 ),
                new DateTime ( 2012, 05, 01 ),
                new DateTime ( 2012, 05, 24 ),
                new DateTime ( 2012, 12, 31 ),
                new DateTime ( 2013, 08, 02 ),
                new DateTime ( 2013, 08, 04 ),
                new DateTime ( 2013, 12, 31 ),
                              };
        Console.WriteLine("Enter a end date in DD MM YYYY format");
        string[] inDate = Console.ReadLine().Split(' ');
        DateTime date = new DateTime(int.Parse(inDate[2]), int.Parse(inDate[1]), int.Parse(inDate[0]));
        DateTime startDate = DateTime.Today < date ? DateTime.Today : date;
        DateTime endDate = DateTime.Today > date ? DateTime.Today : date;
        intervalOfDays = Math.Abs((endDate - startDate).Days);
        for (int i = 0; i < intervalOfDays; i++)
        {
            startDate = startDate.AddDays(1);
            if (startDate.AddDays(i).DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
            {
                isHoliday = false;
                for (int ii = 0; ii < holidays.Length; ii++)
                {
                    if (startDate == holidays[ii])
                    {
                        isHoliday = true;
                        break;
                    }
                }
                if (isHoliday == false)
                {
                    countWorkDays++;
                }
            }
        }
        Console.WriteLine("In this period of days have " + countWorkDays + " work days.");
    }
}
