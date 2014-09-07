
// 06.
// You are given a sequence of positive integer values written into a string, 
// separated by spaces. Write a function that reads these values from given 
// string and calculates their sum. Example:
// 		string = "43 68 9 23 318"  result = 461


using System;

class SomOfStringSequence
{
    static void Main()
    {
        int result = 0;
        string givenString = "43 68 9 23 318";
        string[] matrix = givenString.Split(' ');

        foreach (var item in matrix)
        {
            result += Convert.ToInt32(Convert.ToString(item));
            Console.Write(item + " ");
        }        
        Console.WriteLine("=> result = " + result);
        Console.WriteLine();
    }
}
