// 7. Write a program that encodes and decodes a string using given encryption key (cipher). 
// The key consists of a sequence of characters. The encoding/decoding is done by performing XOR 
// (exclusive or) operation over the first letter of the string with the first of the key, 
// the second – with the second, etc. When the last key character is reached, the next is the first.

namespace StringEncryption
{
    using System;
    using System.Linq;
    using System.Text;

    public class StringEncryption
    {
        private static void Main()
        {
            string message = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string key = "blue";

            string encoded = EncodeText(message, key);
            Console.WriteLine("Encrypted: {0}", encoded);

            string decoded = DecodeText(encoded, key);
            Console.WriteLine("Decrypted: {0}", decoded);
        }

        private static string DecodeText(string message, string key)
        {
            string decoded = EncodeText(message, key);
            return decoded;
        }
  
        private static string EncodeText(string message, string key)
        {
            char[] massageArray = message.ToCharArray();
            char[] keyArray = new char[massageArray.Length];

            StringBuilder encoded = new StringBuilder();

            for (int i = 0, k = 0; i < massageArray.Length; i++, k++)
            {
                if (k >= key.Length)
                {
                    // reset the key to its first character
                    k = 0;
                }

                // at each position of the text is assigned a character from the key
                keyArray[i] = key[k];
            }

            for (int i = 0; i < massageArray.Length; i++)
            {
                encoded.Append((char)(massageArray[i] ^ keyArray[i]));
            }

            return encoded.ToString();
        }
    }
}