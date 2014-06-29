// 14. Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
// Use variable number of arguments
// 15. Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). 
// Use generic method (read in Internet about generic methods in C#).

namespace SetOfDataOperations
{
    using System;
    using System.Linq;

    internal class SetOfDataOperations
    {
        private static readonly Random rndGen = new Random();

        private static void Main()
        {
            Console.Write("Please enter the number of arguments: ");
            int count = int.Parse(Console.ReadLine());

            int[] setOfElements = InputRandomArray(count);
            Console.Write("The set of integers is: ");
            PrintNumber(setOfElements);

            // minimum int of the set
            Console.Write("The minimum int of the set is: ");
            FindMinimum(setOfElements);

            // maximum int of the set
            Console.Write("The miximum int of the set is: ");
            FindMaximum(setOfElements);

            // sum of the set
            Console.Write("The sum of the set is: ");
            SumsetOfElements(setOfElements);

            // product of the set
            Console.Write("The product of the set is: ");
            ProductOfInts(setOfElements);

            // average
            Console.Write("The average of the integers set is: ");
            AverageCalcs(setOfElements);
        }

        private static void ProductOfInts<T>(params T[] setOfElements)
        {
            dynamic product = 1;

            for (int i = 0; i < setOfElements.Length; i++)
            {
                product *= setOfElements[i];
            }

            Console.WriteLine(product);
        }

        private static void SumsetOfElements<T>(params T[] setOfElements)
        {
            dynamic sum = 0;

            for (int i = 0; i < setOfElements.Length; i++)
            {
                sum += setOfElements[i];
            }

            Console.WriteLine(sum);
        }

        private static void FindMaximum<T>(params T[] setOfElements)
        {
            Array.Sort(setOfElements);
            Console.WriteLine("{0}", setOfElements[setOfElements.Length - 1]);
        }

        private static void FindMinimum<T>(params T[] setOfElements)
        {
            Array.Sort(setOfElements);
            Console.WriteLine("{0}", setOfElements[0]);
        }

        private static void AverageCalcs<T>(params T[] sequenceOfInts)
        {
            dynamic avarage = 0;

            for (int i = 0; i < sequenceOfInts.Length; i++)
            {
                avarage += sequenceOfInts[i];
            }

            avarage = avarage / sequenceOfInts.Length;
            Console.Write("{0:F2}", avarage);
            Console.WriteLine();
        }

        private static int[] InputRandomArray(int count)
        {
            int[] intArray = new int[count];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rndGen.Next(-100, 100);
            }

            return intArray;
        }

        private static void PrintNumber<T>(params T[] arrayOfInts)
        {
            Console.WriteLine("{0}", string.Join(",", arrayOfInts));
        }
    }
}