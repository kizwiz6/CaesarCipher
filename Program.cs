namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Enter your secret message:");
            string input = Console.ReadLine().ToLower();
            char[] secretMessage = input.ToCharArray();

            // Encrypt the message
            char[] encryptedMessage = Encrypt(alphabet, secretMessage);
            string encodedString = new string(encryptedMessage);
            Console.WriteLine($"Your encoded message is: {encodedString}.");

            // Decrpyt the message
            char[] decryptedMessage = Decrypt(alphabet, encryptedMessage);
            string decodedString = new string(decryptedMessage);
            Console.WriteLine($"Your decoded message is: {decodedString}.");
        }

        private static char[] Encrypt(char[] alphabet, char[] secretMessage)
        {
            return Transform(alphabet, secretMessage, 3);
        }

        private static char[] Decrypt(char[] alphabet, char[] encryptedMessage)
        {
            return Transform(alphabet, encryptedMessage, -3);
        }

        private static char[] Transform(char[] alphabet, char[] message, int key)
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