// 16. Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 

namespace DaysBetweenDates
{
    using System;
    using System.Globalization;

    public class DaysBetweenDates
    {
        static void Main()
        {
            Console.Write("Enter 1st date: ");
            string firstDate = Console.ReadLine();
            DateTime dateOne = DateTime.ParseExact(firstDate, "d.mm.yyyy", CultureInfo.InvariantCulture);

            Console.Write("Enter 2nd date: ");
            string secondDate = Console.ReadLine();
            DateTime dateTwo = DateTime.ParseExact(secondDate, "d.mm.yyyy", CultureInfo.InvariantCulture);

            int result = (int)(dateTwo - dateOne).TotalDays;
            Console.WriteLine("There are {0} days between {1:dd.mm.yyyy} and {2:dd.mm.yyyy}",result, dateOne, dateTwo);
        }
    }
}
