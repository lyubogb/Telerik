using System;

class StringVariablesAndAssign
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        string thirdValue;
        object full = null;
        full = hello + " " + world;
        Console.WriteLine(full);
        thirdValue = (string) full;
        Console.WriteLine(thirdValue);
    }
}
