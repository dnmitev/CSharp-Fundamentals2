// 3. Write a method that returns the last digit of given integer as an English word. 
// Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".

namespace NameTheLastDigit
{
    using System;
    using System.Linq;

    internal class NameTheLastDigit
    {
        private static void Main()
        {
            Console.Write("Please enter a number: ");
            string number = Console.ReadLine();

            Console.Write("The last digit is named: ");
            WordTheLastDigit(number);
        }

        private static void WordTheLastDigit(string number)
        {
            switch (number[number.Length - 1])
            {
                case '1':
                    Console.WriteLine("One");
                    break;
                case '2':
                    Console.WriteLine("Two");
                    break;
                case '3':
                    Console.WriteLine("Three");
                    break;
                case '4':
                    Console.WriteLine("Four");
                    break;
                case '5':
                    Console.WriteLine("Five");
                    break;
                case '6':
                    Console.WriteLine("Six");
                    break;
                case '7':
                    Console.WriteLine("Seven");
                    break;
                case '8':
                    Console.WriteLine("Eight");
                    break;
                case '9':
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Zero");
                    break;
            }
        }
    }
}