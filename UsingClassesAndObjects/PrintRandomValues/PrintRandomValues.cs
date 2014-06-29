// 2. Write a program that generates and prints to the console 10 random values in the range [100, 200].

namespace PrintRandomValues
{
    using System;
    using System.Linq;

    internal class PrintRandomValues
    {
        private static void Main()
        {
            // declare random values generator
            Random rndGen = new Random();

            // declare a loop to be done 10 times
            for (int i = 0; i < 10; i++)
            {
                // each times print random value [100,201)
                Console.Write(rndGen.Next(100, 201));

                // skip ',' after the 10th value
                if (i != 9)
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine();
        }
    }
}