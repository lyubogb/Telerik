
// 4.
// Write a program that finds how many times a substring is 
// contained in a given text (perform case insensitive search).

// Example: The target substring is "in". The text is as follows:
// We are living in a yellow submarine. We don't have anything else. 
// Inside the submarine is very tight. So we are drinking all the day. 
// We will move out of it in 5 days.

// The result is: 9.

using System;

class StringCounter
{
    static void Main()
    {
        int count = 0;
        int index = 0;
        string buffer = null;
        string searchString = "in";
        string givenString = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days";
        buffer = givenString.ToLower();
        while(true)
        {
            index = buffer.IndexOf(searchString, index);
            if (index > 0)
            {
                count++;
                index++;
                continue;
            }
            break;
        } 
        Console.WriteLine(count);
    }
}