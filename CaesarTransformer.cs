using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    internal class CaesarTransformer : ITransformer
    {
        private char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public char[] Transform(char[] message, int key)
        {
            char[] transformedMessage = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char letter = message[i];
                if (char.IsLetter(letter))
                {
                    int letterPosition = Array.IndexOf(alphabet, letter);
                    int newLetterPosition = (letterPosition + key + 26) % 26; // Adding 26 to handle negative numbers
                    char letterEncoded = alphabet[newLetterPosition];
                    transformedMessage[i] = letterEncoded;
                }
                else
                {
                    transformedMessage[i] = letter;
                }
            }

            return transformedMessage;
        }
    }
}
