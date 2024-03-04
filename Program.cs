namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransformerService encryptor = new TransformerService(new CaesarTransformer());
            TransformerService decryptor = new TransformerService(new CaesarTransformer());

            Console.WriteLine("Enter your secret message:");
            string input = Console.ReadLine().ToLower();
            char[] secretMessage = input.ToCharArray();

            // Encrypt the message
            char[] encryptedMessage = encryptor.Transform(secretMessage, 3);
            string encodedString = new string(encryptedMessage);
            Console.WriteLine($"Your encoded message is: {encodedString}.");

            // Decrpyt the message
            char[] decryptedMessage = decryptor.Transform(encryptedMessage, -3);
            string decodedString = new string(decryptedMessage);
            Console.WriteLine($"Your decoded message is: {decodedString}.");
        }
    }
}