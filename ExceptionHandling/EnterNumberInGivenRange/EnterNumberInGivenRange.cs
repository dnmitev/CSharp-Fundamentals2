// 2. Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
// If an invalid number or non-number text is entered, the method should throw an exception. 
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace EnterNumberInGivenRange
{
    using System;

    internal class EnterNumberInGivenRange
    {
        // define fields to be accessed from all methods
        private static readonly int[] numbers = new int[length];
        private static int start;
        private static int end;

        // define constant values to be used easily in the whole class
        private const int min = 1;
        private const int max = 100;
        private const int length = 10;

        private static void Main()
        {
            try
            {
                // enter the start range position
                Console.Write("Please enter the start of the range: ");
                start = int.Parse(Console.ReadLine());

                // check whether the argument is bigger than 1
                if (start < min || start > max)
                {
                    throw new ArgumentOutOfRangeException();
                }

                // enter the end range position
                Console.Write("Please enter the end of the range: ");
                end = int.Parse(Console.ReadLine());

                // check whether the argument is less than 100
                if (end > max || end < min)
                {
                    throw new ArgumentOutOfRangeException();
                }

                ReadNumber(start, end);
            }
            catch (FormatException)
            {
                Console.WriteLine("You didn't enter an integer");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("[ {0}; {1} ] is not valid in the range [ {2}; {3} ]", start, end, min, max);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("You didn't enter a valid number in the range [ {0}; {1} ]", start, end);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You should enter bigger than previous number.");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }

        private static void ReadNumber(int start, int end)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Number No{0} = ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] < start || numbers[i] > end)
                {
                    throw new IndexOutOfRangeException();
                }
                if (i != 0 && numbers[i] <= numbers[i - 1])
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}