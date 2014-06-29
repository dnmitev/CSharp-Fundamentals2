// 12. Write a program that creates an array containing all letters from the alphabet (A-Z). 
// Read a word from the console and print the index of each of its letters in the array.


namespace IndexOfWordChars
{
    using System;

    class IndexOfWordChars
    {
        static void Main(string[] args)
        {
            // store the A-Z chars in an array
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            // input word from the console
            Console.Write("Please enter a word: ");
            string word = Console.ReadLine();

            // read each char from the word and compare it with the elements of the A-Z array
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Console.Write("{0} has index {1}", word[i], j);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
