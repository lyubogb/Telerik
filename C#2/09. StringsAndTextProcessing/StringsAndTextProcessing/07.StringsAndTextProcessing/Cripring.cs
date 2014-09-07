
// 7.
// Write a program that encodes and decodes a string using 
// given encryption key (cipher). The key consists of a sequence 
// of characters. The encoding/decoding is done by performing XOR 
// (exclusive or) operation over the first letter of the string with 
// the first of the key, the second – with the second, etc. When 
// the last key character is reached, the next is the first.

using System;
using System.Text;

class Cripring
{
    static void Main()
    {
        string kay = "S&S";
        string text = "Когато бях малък гледах един филм \"Малките са порастнали\" и бях много доволен.";
        string dekodeBuffer = Coding(text, kay);
        Console.WriteLine(text);
        Console.WriteLine(Coding(text, kay));
        Console.WriteLine(Coding(dekodeBuffer, kay));
    }
    static string Coding(string inputBuffer, string kay)
    {
        StringBuilder outBuffer = new StringBuilder();
        for (int i = 0; i < inputBuffer.Length; i++)
        {
            outBuffer.Append((char)(inputBuffer[i] ^ kay[i % kay.Length]));
        }
        return outBuffer.ToString();
    }
}