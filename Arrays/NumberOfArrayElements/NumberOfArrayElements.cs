// 5. Write a program that reads two integer numbers N and K and an array of N elements from the console. 
// Find in the array those K elements that have maximal sum.

namespace NumberOfArrayElements
{
    using System;

    class NumberOfArrayElements
    {
        static void Main()
        {
            // enter on the console N and  K values
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            // enter the velues of the array
            Random randomGenerator = new Random();
            int arrSize = n;
            int[] arr = new int[arrSize];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomGenerator.Next(0, 200);
            }

            // print on the console the elements of the array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();

            // finding the K number of elements that have a max sum
            int start = 0;
            int sum = 0;
            int maxSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((i + k) > (arr.Length - 1))
                {
                    break;
                }
                else
                {
                    for (int j = i; j < i + k; j++)
                    {
                        sum += arr[j];
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        start = i;
                    }
                }

                sum = 0;
            }

            Console.Write("{ ");
            for (int i = start; i < start + k; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
}
