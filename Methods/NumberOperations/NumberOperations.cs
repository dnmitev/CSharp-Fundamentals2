/* 13. Write a program that can solve these tasks:
* Reverses the digits of a number
* Calculates the average of a sequence of integers
* Solves a linear equation a * x + b = 0
Create appropriate methods.Provide a simple text-based menu for the user to choose which task to solve.		
Validate the input data:
* The decimal number should be non-negative
* The sequence should not be empty
* a should not be equal to 0   */

namespace NumberOperations
{
    using System;
    using System.Linq;

    internal class NumberOperations
    {
        private static readonly Random rndGen = new Random();

        private static void Main()
        {
            Console.WriteLine("Enter the digit to choose which task you want to solve: ");
            Console.WriteLine("1 -> Reverse the digits of a number");
            Console.WriteLine("2 -> Calculate the average of a sequence of integers");
            Console.WriteLine("3 -> Solves a linear equation a * x + b = 0");
            Console.WriteLine("0 -> Exit");

            Console.Write("Please make you choice: ");
            int input = int.Parse(Console.ReadLine());

            UserMenu(input);
        }

        private static void UserMenu(int input)
        {
            switch (input)
            {
                case 1:
                    Console.WriteLine("You have chosen to reverse the number's digits!");
                    ReverseNumberDigits();
                    break;
                case 2:
                    Console.WriteLine("You have chosen to find the avarage of integers sequence!");
                    AverageCalcs();
                    break;
                case 3:
                    Console.WriteLine("You have chosen to solve a linear equation!");
                    SolveLinearEquation();
                    break;
                case 0:
                    Console.WriteLine("You have chosen to terminate the program!");
                    return;
                default:
                    Console.WriteLine("Wrong choice! Please make a valid choice next time.");
                    break;
            }
        }

        private static void SolveLinearEquation()
        {
            double a, b;

            do
            {
                Console.Write("Please enter coefficient a: ");
                a = double.Parse(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("Please enter value for a, that is not equal to 0.");
                }
            }
            while (a == 0);

            Console.Write("Please enter coefficient b: ");
            b = double.Parse(Console.ReadLine());

            double result = 0;
            result = -b / a;

            Console.WriteLine("{0}x + {1} = 0 has result x={2:F2}", a, b, result);
        }

        private static void AverageCalcs()
        {
            int count;

            do
            {
                Console.Write("Please enter the length of the sequence: ");
                count = int.Parse(Console.ReadLine());

                if (count == 0)
                {
                    Console.WriteLine("You have entered an empty sequence, please enter a valid one.");
                }
            }
            while (count == 0);

            int[] sequenceOfInts = InputRandomArray(count);

            double avarage = 0;

            for (int i = 0; i < sequenceOfInts.Length; i++)
            {
                avarage += sequenceOfInts[i];
            }

            avarage = avarage / count;
            Console.Write("The avarage of {0} is {1:F2}", string.Join(",", sequenceOfInts), avarage);
            Console.WriteLine();
        }

        private static void ReverseNumberDigits()
        {
            string number;
            // check for non-negative input
            do
            {
                Console.Write("Please enter a number to reverse its digits: ");
                number = Console.ReadLine();

                if (number[0] == '-')
                {
                    Console.WriteLine("Please enter a non-negative number!");
                }
            }
            while (number[0] == '-');

            int[] digits = new int[number.Length];

            // reverse the number's digits
            for (int i = 0; i < number.Length; i++)
            {
                digits[i] = number[number.Length - 1 - i] - '0';
            }

            // print the result
            Console.Write("The reversed number is: ");
            PrintNumber(digits);
        }

        private static int[] InputRandomArray(int count)
        {
            int[] intArray = new int[count];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rndGen.Next(0, 10);
            }

            return intArray;
        }

        private static void PrintNumber(int[] digits)
        {
            Console.WriteLine("{0}", string.Join("", digits));
        }
    }
}