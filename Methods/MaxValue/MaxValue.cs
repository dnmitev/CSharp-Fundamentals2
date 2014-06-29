// 2. Write a method GetMax() with two parameters that returns the bigger of two integers. 
// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

namespace MaxValue
{
    using System;
    using System.Linq;

    internal class MaxValue
    {
        private static void Main()
        {
            // enter three numbers on the console
            Console.Write("Enter 1st number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter 3rd number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Max number is: {0}", GetMax(GetMax(firstNumber, secondNumber), thirdNumber));
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            int max;

            if (firstNumber > secondNumber)
            {
                max = firstNumber;
            }
            else
            {
                max = secondNumber;
            }

            return max;
        }
    }
}