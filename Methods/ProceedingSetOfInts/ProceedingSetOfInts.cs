// 14. Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
// Use variable number of arguments

namespace ProceedingSetOfInts
{
    using System;
    using System.Linq;
    using System.Numerics;

    internal class ProceedingSetOfInts
    {
        private static readonly Random rndGen = new Random();

        private static void Main()
        {
            Console.Write("Please enter the number of arguments: ");
            int count = int.Parse(Console.ReadLine());

            int[] setOfInts = InputRandomArray(count);
            Console.Write("The set of integers is: ");
            PrintNumber(setOfInts);

            // minimum int of the set
            Console.Write("The minimum int of the set is: ");
            FindMinimum(setOfInts);

            // maximum int of the set
            Console.Write("The miximum int of the set is: ");
            FindMaximum(setOfInts);

            // sum of the set
            Console.Write("The sum of the set is: ");
            SumSetOfInts(setOfInts);

            // product of the set
            Console.Write("The product of the set is: ");
            ProductOfInts(setOfInts);

            // average
            Console.Write("The average of the integers set is: ");
            AverageCalcs(setOfInts);
        }

        private static void ProductOfInts(int[] setOfInts)
        {
            BigInteger product = 1;

            for (int i = 0; i < setOfInts.Length; i++)
            {
                product *= setOfInts[i];
            }

            Console.WriteLine(product);
        }

        private static void SumSetOfInts(int[] setOfInts)
        {
            int sum = 0;

            for (int i = 0; i < setOfInts.Length; i++)
            {
                sum += setOfInts[i];
            }

            Console.WriteLine(sum);
        }

        private static void FindMaximum(int[] setOfInts)
        {
            SelectionSort(setOfInts);
            Console.WriteLine("{0}", setOfInts[setOfInts.Length - 1]);
        }

        private static void FindMinimum(int[] setOfInts)
        {
            SelectionSort(setOfInts);
            Console.WriteLine("{0}", setOfInts[0]);
        }

        private static void SelectionSort(int[] setOfInts)
        {
            for (int i = 0; i < setOfInts.Length; i++)
            {
                for (int j = i; j < setOfInts.Length; j++)
                {
                    if (setOfInts[j] < setOfInts[i])
                    {
                        int temp = setOfInts[i];
                        setOfInts[i] = setOfInts[j];
                        setOfInts[j] = temp;
                    }
                }
            }
        }

        private static void AverageCalcs(int[] sequenceOfInts)
        {
            double avarage = 0;

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

        private static void PrintNumber(int[] arrayOfInts)
        {
            Console.WriteLine("{0}", string.Join(",", arrayOfInts));
        }
    }
}