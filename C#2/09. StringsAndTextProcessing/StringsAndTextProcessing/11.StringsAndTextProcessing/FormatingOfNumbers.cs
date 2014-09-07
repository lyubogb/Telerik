
// 11.
// Write a program that reads a number and prints it as a decimal number,
// hexadecimal number, percentage and in scientific notation. 
// Format the output aligned right in 15 symbols.


using System;

class FormatingOfNumbers

{
    static void Main()
    {
        string number = "300";
        Console.WriteLine(string.Format("decimal     {0,15}", int.Parse(number)));
        Console.WriteLine(string.Format("hexadecimal {0,15:X4}", int.Parse(number)));
        Console.WriteLine(string.Format("percentage  {0,15:P2}", (int.Parse(number))));
        Console.WriteLine(string.Format("scientific  {0,15:E}", float.Parse(number)));
    }
}