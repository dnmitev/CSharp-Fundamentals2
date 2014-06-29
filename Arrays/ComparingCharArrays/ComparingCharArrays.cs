// 3.Write a program that compares two char arrays lexicographically (letter by letter).

namespace ComparingCharArrays
{
    using System;

    class ComparingCharArrays
    {
        static void Main()
        {
            // enter the size of the arrays from the console
            Console.Write("Please enter size of the first array:");
            int sizeOfFirst = int.Parse(Console.ReadLine());

            Console.Write("Please enter size of the second array:");
            int sizeOfSecond = int.Parse(Console.ReadLine());

            // initializing the two arrays
            char[] firstCharArray = new char[sizeOfFirst];
            char[] secondCharArray = new char[sizeOfSecond];

            // enter values for the arrays' elements
            for (int index = 0; index < firstCharArray.Length; index++)
            {
                Console.Write("firstArray[{0}] = ", index);
                firstCharArray[index] = char.Parse(Console.ReadLine());
            }

            for (int index = 0; index < secondCharArray.Length; index++)
            {
                Console.Write("firstArray[{0}] = ", index);
                secondCharArray[index] = char.Parse(Console.ReadLine());
            }

            // comparing arrays by elements
            bool areLexEqual = true;

            if (firstCharArray.Length == secondCharArray.Length)
            {
                for (int index = 0; index < firstCharArray.Length; index++)
                {
                    if (firstCharArray[index] != secondCharArray[index])
                    {
                        areLexEqual = false;
                        break;
                    }
                }
                Console.WriteLine("Two arrays are lexicographically equal is: {0}",areLexEqual);
            }
            else
            {
                areLexEqual = false;
                Console.WriteLine("Two arrays are lexicographically equal is: {0}", areLexEqual);
            }

        }
    }
}
