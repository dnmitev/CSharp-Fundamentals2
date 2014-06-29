// 11. Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
// Example: x2 + 5 = 1x2 + 0x + 5 -> 5,0,1

namespace Polynomials
{
    using System;
    using System.Linq;

    internal class Polynomials
    {
        private static readonly Random rndGen = new Random();

        private static void Main()
        {
            // randomly generate first polynomial
            int[] firstPolynomial = InputRandomArray();
            Console.Write("First polynomial: ");
            PrintPolynomial(firstPolynomial);

            // randomly generate second polynomial
            int[] secondPolynomial = InputRandomArray();
            Console.Write("Second polynomial: ");
            PrintPolynomial(secondPolynomial);

            // the result of adding the polynomials
            int[] result = SumOfPolynomials(firstPolynomial, secondPolynomial);
            Console.Write("The sum of the polynomials is: ");
            PrintPolynomial(result);
        }

        private static int[] SumOfPolynomials(int[] firstPolynomial, int[] secondPolynomial)
        {
            int minLength = 0;
            int maxLength = 0;

            bool firstIsLonger = false;

            // find min length and shortest polynomial
            if (firstPolynomial.Length > secondPolynomial.Length)
            {
                minLength = secondPolynomial.Length;
                maxLength = firstPolynomial.Length;
                firstIsLonger = true;
            }
            else
            {
                minLength = firstPolynomial.Length;
                maxLength = secondPolynomial.Length;
            }

            int[] result = new int[maxLength];

            // add until the length is equal
            for (int i = 0; i < minLength; i++)
            {
                result[i] = firstPolynomial[i] + secondPolynomial[i];
            }

            // add the remaining elements of the longer polynomial to the result
            for (int i = minLength; i < result.Length; i++)
            {
                if (firstIsLonger)
                {
                    result[i] = firstPolynomial[i];
                }
                else
                {
                    result[i] = secondPolynomial[i];
                }
            }

            return result;
        }

        private static void PrintPolynomial(int[] polynomial)
        {
            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                if (polynomial[i] != 0 && i != 0)
                {
                    if (polynomial[i - 1] >= 0)
                    {
                        Console.Write("{0}x^{1}+", polynomial[i], i);
                    }
                    else
                    {
                        Console.Write("{0}x^{1}", polynomial[i], i);
                    }
                }
                else if (i == 0)
                {
                    Console.Write("{0}", polynomial[i]);
                }
            }

            Console.WriteLine();
        }

        private static int[] InputRandomArray()
        {
            int[] intArray = new int[rndGen.Next(2, 10)];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rndGen.Next(-10, 10);
            }

            return intArray;
        }
    }
}