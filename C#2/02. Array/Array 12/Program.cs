// 12.
// Write a program that creates an array containing all letters
// from the alphabet (A-Z). Read a word from the console and print 
// the index of each of its letters in the array.


using System;

class PrintLetterIndex
{

    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)('A' + i);
        }
        Console.Write("Enter word: ");
        string word = Console.ReadLine().ToUpper();
        foreach (char letter in word)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (letter == alphabet[i])
                {
                    Console.WriteLine("The index of '{0}' is {1}", letter, i);
                }
            }
        }
    }
}
