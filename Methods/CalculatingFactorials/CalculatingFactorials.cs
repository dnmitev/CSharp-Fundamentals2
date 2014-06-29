// 10. Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that 
// multiplies a number represented as array of digits by given integer number. 

namespace CalculatingFactorials
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class CalculatingFactorials
    {
        private static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            string factorial = FactorialCalcs(n);
            Console.WriteLine("{0}! = {1}", n, factorial);
        }

        private static string FactorialCalcs(int n)
        {
            string finalResult = "1";

            for (int i = 2; i <= n; i++)
            {
                finalResult = Multiply(finalResult, i);
            }

            return finalResult;
        }

        private static string Multiply(string firstNum, int secondNum)
        {
            List<int> digits = GetDigits(firstNum);

            StringBuilder result = new StringBuilder();

            int add = 0;

            for (int i = 0; i < digits.Count; i++)
            {
                int digitResult = digits[i] * secondNum;
                digitResult += add;

                if (digitResult < 10)
                {
                    result.Insert(0, digitResult);
                    add = 0;
                }
                else if (digitResult >= 10)
                {
                    result.Insert(0, digitResult % 10);
                    add = digitResult / 10;
                }
            }

            if (add > 0)
            {
                result.Insert(0, add);
            }

            string endResult = Convert.ToString(result);

            return endResult;
        }

        private static List<int> GetDigits(string number)
        {
            List<int> digits = new List<int>();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                digits.Add(int.Parse(Convert.ToString(number[i])));
            }

            return digits;
        }
    }
}