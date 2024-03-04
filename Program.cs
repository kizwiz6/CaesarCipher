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
            char[] encryptedMessage = Encrypt(alphabet, secretMessage);

            string encodedString = String.Join("", encryptedMessage);
            Console.WriteLine($"Your encoded message is: {encodedString}.");
        }

        private static char[] Encrypt(char[] alphabet, char[] secretMessage)
        {
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];

                if (char.IsLetter(letter))
                {
                    int letterPosition = Array.IndexOf(alphabet, letter);
                    int newLetterPosition = (letterPosition + 3) % 26;
                    char letterEncoded = alphabet[newLetterPosition];
                    encryptedMessage[i] = letterEncoded;
                }
                else
                {
                    // If it's not a letter, keep it as is
                    encryptedMessage[i] = letter;
                }

            }

            return encryptedMessage;
        }
    }
}