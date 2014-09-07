
// 8.
// Write a program that extracts from a given text all sentences 
// containing given word. Example: The word is "in". 
// The text is:
// We are living in a yellow submarine. We don't have anything else. 
// Inside the submarine is very tight. So we are drinking all the day. 
// We will move out of it in 5 days.
//
// The expected result is:
// We are living in a yellow submarine.
// We will move out of it in 5 days.

// Consider that the sentences are separated by "." and the words 
// – by non-letter symbols.

using System;
using System.Text;
using System.Text.RegularExpressions;

class FindingSentences
{
    static void Main()
    //    {
    //        string givenText = @" We are living in a yellow submarine. We don't have anything else.
    //Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
    //        /////////////////////////////////////////////////////////////////////////////////// разделяне на редове
    //        char[] separators = { '.', '\n', '\r' };
    //        string searchWord = "in";
    //        string[] onRows = givenText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    //        /////////////////////////////////////////////// проверка по шаблона и Appending във съответния mu масив
    //        StringBuilder withIn = new StringBuilder();
    //        StringBuilder withoutIn = new StringBuilder();

    //        for (int i = 0; i < onRows.Length; i++)
    //        {
    //            int index = onRows[i].ToLower().IndexOf(" " + searchWord.ToLower());
    //            if (onRows[i].ToLower().IndexOf(" " + searchWord.ToLower() + " ") != -1 ||
    //                onRows[i].ToLower().IndexOf(" " + searchWord.ToLower() + ",") != -1 ||
    //                onRows[i].ToLower().IndexOf(" " + searchWord.ToLower() + ".") != -1)
    //            {
    //                withIn.Append(onRows[i] + "\n");
    //            }            
    //        }
    //        Console.WriteLine("withIn:\n" + withIn);
    //    }
    {
        string givenText = @" We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        string[] aa = Regex.Split(givenText, @"([A-Z]+.*?\b[\.])");
        Console.WriteLine("withIn:");
        foreach (var item in aa)
        {
            if (Regex.IsMatch(item, @"\s*\b([A-Z][^\.]*\b " + word + @" \b.*?\.)") == true)
            {
                Console.WriteLine(item);
            }
        }
    }
}