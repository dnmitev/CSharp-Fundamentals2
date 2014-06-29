// 17.Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the 
// date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

namespace AddTimeToDate
{
    using System;
    using System.Globalization;

    public class AddTimeToDate
    {
        static void Main()
        {
            string input = "14.01.2013 21:00:00";

            DateTime date = DateTime.ParseExact(input, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            date = date.AddHours(6.5);

            string weekDay = date.ToString("dddd", new CultureInfo("bg-BG"));
            Console.WriteLine("{0}, {1}", date, weekDay);
        }
    }
}
