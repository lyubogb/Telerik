
// 3.
// Write a program to check if in a given 
// expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).

using System;

class CheckingBrackets
{
    static void Main()
    {
        string str = "((a+b)/5-d)";
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '(')
            {
                count++;
            }
            if (str[i] == ')')
            {
                count--;
            }
            if (count < 0)
            {
                break;
            }
        }
        Console.WriteLine("Expression {1} is {0}" , count != 0 ? "notcorrect." : "correct.", str);
    }
}