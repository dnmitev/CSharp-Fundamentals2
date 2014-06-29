// 1. Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number".
// In all cases finally print "Good bye". Use try-catch-finally.

namespace SqrtOfInt
{
    using System;
    using System.Linq;

    internal class SqrtOfInt
    {
        private static void Main()
        {
            try
            {
                // enter the input number
                Console.Write("Please enter a positive integer: ");
                int input = int.Parse(Console.ReadLine());

                // if the input number is less than 0 throw an exception
                CheckIfNegative(input);

                // if no exception thrown initialize result and print it
                double result = Math.Sqrt(input);
                Console.WriteLine("Sqrt({0}) = {1}", input, result);
            }
            catch (FormatException)
            {
                // print an adequate massage
                Console.WriteLine("Invalid input! You should enter a number.");
            }
            catch (InvalidOperationException)
            {
                // print an adequate massage
                Console.WriteLine("Invalid input! You should enter a positive number.");
            }
            catch (OverflowException)
            {
                // print an adequate massage
                Console.WriteLine("Invalid input! You have entered too big number. The max you can use is: {0}.", int.MaxValue);
            }
            finally
            {
                // print massage that would be executed no matter is there an exception thrown
                Console.WriteLine("Good bye!");
            }
        }

        private static void CheckIfNegative(int input)
        {
            if (input < 0)
            {
                throw new InvalidOperationException();
            }
        }
    }
}