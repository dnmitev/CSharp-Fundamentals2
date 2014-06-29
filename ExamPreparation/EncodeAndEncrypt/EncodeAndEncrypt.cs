// BGCoder: http://bgcoder.com/Contests/Practice/Index/95#3

namespace EncodeAndEncrypt
{
    using System;
    using System.Linq;
    using System.Text;

    public class EncodeAndEncrypt
    {
        private static string Encrypt(string message, string cypher)
        {
            string result = string.Empty;

            if (message.Length > cypher.Length)
            {
                result = EncryptWithLongerMessage(message, cypher);
            }
            else
            {
                result = EncryptWithLongerCypher(message, cypher);
            }

            return result;
        }

        private static string EncryptWithLongerCypher(string message, string cypher)
        {
            StringBuilder result = new StringBuilder(message);

            int messageIndex = 0;

            for (int i = 0; i < cypher.Length; i++)
            {
                char messageSymbol = result[messageIndex];
                char cypherSymbol = cypher[i];
                char encryptedSymbol = EncryptSymbol(messageSymbol, cypherSymbol); 

                result[messageIndex] = encryptedSymbol;

                messageIndex++;

                if (messageIndex == message.Length)
                {
                    messageIndex = 0;
                }
            }

            return result.ToString();
        }

        private static string EncryptWithLongerMessage(string message, string cypher)
        {
            StringBuilder result = new StringBuilder();

            int cypherIndex = 0;

            for (int i = 0; i < message.Length; i++)
            {
                char messageSymbol = message[i];
                char cypherSymbol = cypher[cypherIndex];
                char encryptedSymbol = EncryptSymbol(messageSymbol, cypherSymbol);

                result.Append(encryptedSymbol);

                cypherIndex++;

                if (cypherIndex == cypher.Length)
                {
                    cypherIndex = 0;
                }
            }

            return result.ToString();
        }

        private static char EncryptSymbol(char messageSymbol, char cypherSymbol)
        {
            int messageSymbolCode = messageSymbol - 'A';
            int cypherSymbolCode = cypherSymbol - 'A';

            int xoredSymbol = messageSymbolCode ^ cypherSymbolCode;
            char encrypted = (char)(xoredSymbol + 'A');

            return encrypted;
        }

        private static string Encode(string text)
        {
            StringBuilder result = new StringBuilder();

            char previousSymbol = text[0];
            int counter = 1;

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == previousSymbol)
                {
                    counter++;
                }
                else
                {
                    if (counter == 1)
                    {
                        result.Append(previousSymbol);
                    }
                    else if (counter == 2)
                    {
                        result.Append(new string(previousSymbol, 2));
                    }
                    else
                    {
                        result.AppendFormat("{0}{1}", counter, previousSymbol.ToString());
                    }

                    counter = 1;
                    previousSymbol = text[i];
                }
            }

            if (counter == 1)
            {
                result.Append(previousSymbol);
            }
            else if (counter == 2)
            {
                result.Append(new string(previousSymbol, 2));
            }
            else
            {
                result.AppendFormat("{0}{1}", counter, previousSymbol.ToString());
            }

            return result.ToString();
        }

        private static void Main()
        {
            string message = Console.ReadLine();
            string cypher = Console.ReadLine();

            string finalResult = string.Format("{0}{1}", Encode(string.Format("{0}{1}", Encrypt(message, cypher), cypher)), cypher.Length);
            Console.WriteLine(finalResult);
        }
    }
}