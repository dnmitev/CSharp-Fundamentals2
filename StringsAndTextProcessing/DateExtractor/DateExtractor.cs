// 19. Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
// Display them in the standard date format for Canada.

// http://gskinner.com/RegExr/

namespace DateExtractor
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text.RegularExpressions;

    public class DateExtractor
    {
        static void Main(string[] args)
        {
            string text =
                @" Видео - 06.01.2013 - Ники
                   Видео - 08.01.2013 - Жоро
                   Видео - 12.02.2013 - Жоро";

            string pattern = @"(0?[1-9]|[12][0-9]|3[01])[-/.](0?[1-9]|1[012])[- /.](19|20)?\d\d";

            MatchCollection matches = Regex.Matches(text, pattern);

            DateTime date;

            foreach (Match match in matches)
            {
                if (DateTime.TryParseExact(match.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                }
            }
        }
    }
}
