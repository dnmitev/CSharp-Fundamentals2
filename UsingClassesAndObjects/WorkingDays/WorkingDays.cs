// 5.Write a method that calculates the number of workdays between today and given date, passed as parameter. 
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

namespace WorkingDays
{
    using System;
    using System.Linq;

    internal class WorkingDays
    {
        // declare the holiday array
        private static readonly DateTime[] holidays =
        {
            new DateTime(2014, 3, 3), new DateTime(2014, 4, 18), new DateTime(2014, 5, 1), new DateTime(2014, 5, 2),
            new DateTime(2014, 5, 5), new DateTime(2014, 5, 6), new DateTime(2014, 9, 22), new DateTime(2014, 5, 1), 
            new DateTime(2014, 12, 24), new DateTime(2014, 12, 25), new DateTime(2014, 12, 26), new DateTime(2014, 12, 31)
        };

        private static void Main()
        {
            // declare today
            DateTime today = new DateTime();
            today = DateTime.Now;

            // declare a variable to store the entered date
            DateTime targetDate = new DateTime();
            targetDate = DateTime.Parse(Console.ReadLine());

            // print the result on the console
            int workingDays = GetWorkDays(today, targetDate);
            Console.WriteLine("The count of working days from {0:dd/m/yyyy} to {1:dd/m/yyyy} are {2}", today, targetDate, workingDays);
        }

        private static void TrimPeriod(DateTime start, DateTime end)
        {
            if (start.DayOfWeek == DayOfWeek.Saturday)
            {
                start = start.AddDays(2);
            }

            if (start.DayOfWeek == DayOfWeek.Sunday)
            {
                start = start.AddDays(1);
            }

            if (end.DayOfWeek == DayOfWeek.Saturday)
            {
                end = end.AddDays(-2);
            }

            if (end.DayOfWeek == DayOfWeek.Sunday)
            {
                end = end.AddDays(-1);
            }
        }

        private static int GetWorkDays(DateTime start, DateTime end)
        {
            TrimPeriod(start, end);

            int offset = (int)(end - start).TotalDays + 1;
            int result = offset / 7 * 5 + offset % 7;

            return FilterHolidays(start, end, Math.Max(result, 0));
        }

        private static int FilterHolidays(DateTime start, DateTime end, int result)
        {
            foreach (var holiday in holidays)
            {
                if (start <= holiday && holiday <= end && !(holiday.DayOfWeek == DayOfWeek.Saturday || holiday.DayOfWeek == DayOfWeek.Sunday))
                {
                    result--;
                }
            }

            return result;
        }
    }
}