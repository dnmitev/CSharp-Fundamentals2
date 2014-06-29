// 7.Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

namespace Any2Any
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Any2Any
    {
        private static void Main()
        {
            // enter the "s" base
            Console.Write("Please enter s = ");
            int s = int.Parse(Console.ReadLine());

            // enter the number
            Console.Write("Please enter a number: ");
            string number = Console.ReadLine();

            // enter the "d" base
            Console.Write("Please enter d = ");
            int d = int.Parse(Console.ReadLine());

            // convert from numeral system "s" based to 10 based
            int decNum = 0;
            decNum = ConvertToDec(number, s);

            // convert from 10 based numeral system to "d" based
            char[] newNumber = Convert2Hex(decNum, d);
            Array.Reverse(newNumber);
            Console.WriteLine("Representation in {0} based numeral system is {1}", d, string.Join("",newNumber));
        }

        private static char[] Convert2Hex(int decNum, int numeralBase)
        {
            char[] hexSymbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            StringBuilder hexNum = new StringBuilder();

            while (decNum != 0)
            {
                hexNum.Append(hexSymbols[decNum % numeralBase]);
                decNum = decNum / numeralBase;
            }

            return hexNum.ToString().ToCharArray();
        }

        private static int ConvertToDec(string number, int numeralBase)
        {
            // declare a variable to store the decimal representation of the binary number
            int decNum = 0;

            // find the highest power of the base (2 in this case)
            int highPower = number.Length - 1;

            // go throught the digits of the number
            for (int powIndex = 0; powIndex < number.Length; powIndex++)
            {
                int digit = number[powIndex] - '0';
                decNum = decNum + digit * Power(numeralBase, highPower - powIndex);
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