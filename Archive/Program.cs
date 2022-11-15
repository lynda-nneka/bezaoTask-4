// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using encryptionDecryptionKey;

public static class program
{
    static void Main(string[] args)
    {

        string key = "b14ca5898a4e4133bbce2ea2315a1916";


        Console.WriteLine("Please enter a string for encryption");
        string userInput = Console.ReadLine();

        string encryptedMessage = EncryptionDecryptionOperation.EncryptString(key, userInput);

        Console.WriteLine("This is the encrypted message: " + encryptedMessage);
        string decryptedMessage = EncryptionDecryptionOperation.DecryptString(key, encryptedMessage);
        Console.WriteLine("This is the decrypted message: " + decryptedMessage);

        Console.ReadKey();

    }

}


