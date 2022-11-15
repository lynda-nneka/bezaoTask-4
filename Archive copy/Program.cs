using System;
using numbersInWords;
using System.IO;


public static class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter a number");

        string number = Console.ReadLine();
        

        var words = numbersToWordsConverter.numbersToWords(int.Parse(number));
        Console.WriteLine(words);

    }

}
