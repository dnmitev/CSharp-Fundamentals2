// 11. Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
// percentage and in scientific notation. Format the output aligned right in 15 symbols.

namespace ReadAndPrintNumerb
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ReadAndPrintNumber
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

            int number = int.Parse(input);

            Console.WriteLine("Decimal: {0,15}", number);
            Console.WriteLine("Hexadecimal: {0,15:X}", number);
            Console.WriteLine("Percentage: {0,15:P}", number);
            Console.WriteLine("Scientific: {0,15:E}", number);
        }
    }
}
