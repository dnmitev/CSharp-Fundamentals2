namespace BunnyFactory
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    class BunnyFactory
    {
        static List<int> cages = new List<int>();

        static void Main()
        {
            ReadInputData();
            List<int> result = ProccessTheFactory();

            Console.WriteLine(string.Join(" ", result));
        }

        private static List<int> ProccessTheFactory()
        {
            List<int> currentCages = cages;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < currentCages.Count; i++)
            {
                BigInteger sum = 0;
                BigInteger product = 1;

                // find s (initial sum) for every new list
                int s = 0;

                for (int count = 0; count <= i; count++)
                {
                    s += currentCages[count];
                }

                if ((currentCages.Count - (s + i + 1)) < 0)
                {
                    return currentCages;
                }

                for (int j = i + 1; j <= s + i; j++)
                {
                    sum += (BigInteger)currentCages[j];
                    product *= (BigInteger)currentCages[j];
                }

                sb.Append(sum.ToString());
                sb.Append(product.ToString());

                for (int k = s + i + 1; k < currentCages.Count; k++)
                {
                    sb.Append(currentCages[k]);
                }

                DeleteOnesAndZeros(sb);

                currentCages.Clear();

                currentCages = GetListUpdated(sb);

                sb.Clear();
            }

            return currentCages;
        }

        private static List<int> GetListUpdated(StringBuilder sb)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < sb.Length; i++)
            {
                int number = sb[i] - '0';

                result.Add(number);
            }

            return result;
        }

        private static void DeleteOnesAndZeros(StringBuilder sb)
        {
            for (int i = 0; i < sb.Length; i++)
            {
                for (int j = i; j < sb.Length; j++)
                {
                    if (sb[j] == '0' || sb[j] == '1')
                    {
                        sb.Remove(j, 1);
                    }
                }
            }
        }

        private static void ReadInputData()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    return;
                }
                else
                {
                    int bunnies = int.Parse(input);
                    cages.Add(bunnies);
                }
            }
        }
    }
}
