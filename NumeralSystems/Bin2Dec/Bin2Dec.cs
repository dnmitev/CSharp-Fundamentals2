// 2.Write a program to convert binary numbers to their decimal representation.

namespace Bin2Dec
{
    using System;
    using System.Linq;

    internal class Bin2Dec
    {
        private static void Main()
        {
            Console.Write("Please enter a binary number: ");
            string binary = Console.ReadLine();

            Console.WriteLine("The decimal expression is: {0}", ConvertToDec(binary));
        }

        private static int ConvertToDec(string binary)
        {
            // declare a variable to store the decimal representation of the binary number
            int decNum = 0;

            // find the highest power of the base (2 in this case)
            int highPower = binary.Length - 1;

            // go throught the digits of the number
            for (int powIndex = 0; powIndex < binary.Length; powIndex++)
            {
                int digit = binary[powIndex] - '0';
                decNum = decNum + digit * Power(2, highPower - powIndex);
            }

            return decNum;
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