// 15. Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm.
using System;
using System.Linq;

namespace SieveOfEratosthenes
{
    internal class SieveOfEratosthenes
    {
        private static void Main()
        {
            bool[] numbers = new bool[10000000];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = true;
            }

            int enough = (int)Math.Sqrt(numbers.Length);

            for (int i = 2; i <= enough; i++)
            {
                if (numbers[i])
                {
                    for (int j = i * i; j < numbers.Length; j += i)
                    {
                        numbers[j] = false;
                    }
                }
            }

            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i])
                {
                    Console.Write(string.Format("{0} ", i));
                }
            }
        }
    }
}