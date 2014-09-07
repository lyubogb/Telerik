
// 6
// Write a program that reads from the console a string of
// maximum 20 characters. If the length of the string is 
// less than 20, the rest of the characters should be filled 
// with '*'. Print the result string into the console.

// Използвайте метода PadRight(…) от класа String.

using System;

class ChangeCharactersInText
{
    static void Main()
    {       
        Console.WriteLine(Console.ReadLine().PadRight(20).Replace(' ','*'));
    }
}