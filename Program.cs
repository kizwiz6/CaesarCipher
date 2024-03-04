namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encryptor encryptor = new Encryptor();
            Decryptor decryptor = new Decryptor();

            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Enter your secret message:");
            string input = Console.ReadLine().ToLower();
            char[] secretMessage = input.ToCharArray();

            // Encrypt the message
            char[] encryptedMessage = encryptor.Encrypt(secretMessage);
            string encodedString = new string(encryptedMessage);
            Console.WriteLine($"Your encoded message is: {encodedString}.");

            // Decrpyt the message
            char[] decryptedMessage = decryptor.Decrypt(encryptedMessage);
            string decodedString = new string(decryptedMessage);
            Console.WriteLine($"Your decoded message is: {decodedString}.");
        }
    }
}