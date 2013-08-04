// 07.
// Write a method that reverses the digits of given decimal number. Example: 256  652


using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            string number = (Console.ReadLine());
            Console.WriteLine(Revers(number));
        }
    }
     
    static string Revers(string word)
    {
        string newWord = null;
        for (int i = word.Length-1; i >= 0 ; i--)
        {
            newWord += word[i];
        }
        return newWord;
    }
}
