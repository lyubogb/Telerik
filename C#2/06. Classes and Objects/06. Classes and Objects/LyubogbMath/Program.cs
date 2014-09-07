using System;
using System.Collections.Generic;
using System.Text;
namespace MathExpression
{
    public class Program
    {
        public static string TrimInput(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    result.Append(input[i]);
                }
            }
            return result.ToString();
        }
        public void Main()
        {
            string input = Console.ReadLine();
            string TrimmedInput = TrimInput(input);
            Console.WriteLine(TrimmedInput);
        }
    }
}
