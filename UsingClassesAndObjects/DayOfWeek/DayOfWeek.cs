// 3. Write a program that prints to the console which day of the week is today. Use System.DateTime.

namespace DayOfWeek
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class DayOfWeek
    {
        static void Main()
        {
            // declare variable of class DateTime
            DateTime today = new DateTime();

            // assign today with the current date and time
            today = DateTime.Now;

            // print the day of week
            Console.WriteLine("So today is : {0}",today.DayOfWeek);
        }
    }
}
