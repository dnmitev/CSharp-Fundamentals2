// 4.Write a program to convert hexadecimal numbers to their decimal representation.

namespace Hex2Dec
{
    using System;
    using System.Linq;

    internal class Hex2Dec
    {
        private static void Main()
        {
            Console.Write("Please enter a hexadecimal number: ");
            string hexadecimal = Console.ReadLine();

            // make all letters capital 
            hexadecimal = hexadecimal.ToUpper();

            Console.WriteLine("The decimal expression is: {0}", ConvertToDec(hexadecimal));
        }

        private static int ConvertToDec(string hexadecimal)
        {
            // declare a variable to store the decimal representation of the binary number
            int decNum = 0;

            // find the highest power of the base (2 in this case)
            int highPower = hexadecimal.Length - 1;

            // go throught the digits of the number
            for (int powIndex = 0; powIndex < hexadecimal.Length; powIndex++)
            {
                int digit = GetDigit(hexadecimal[powIndex]);
                decNum = decNum + digit * Power(16, highPower - powIndex);
            }

            return decNum;
        }

        private static int GetDigit(char p)
        {
            int digit = 0;

            char[] hexSymbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            digit = Array.IndexOf(hexSymbols, p);

            return digit;
        }

        private static int Power(int powerBase, int power)
        {
            int powered = powerBase;

            if (power != 0)
            {
                for (int powIndex = 1; powIndex < power; powIndex++)
                {
                    powered *= powerBase;
                }
            }
            else
            {
                return 1;
            }

            return powered;
        }
    }
}