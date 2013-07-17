using System;

class DeclareTwoStringVariables
{
    static void Main()
    {
        string value1 = "The \"use\" of quotations causes difficulties.";
        string value2 = @"The ""use"" of quotations causes difficulties."; 
        Console.WriteLine(value1);
        Console.WriteLine(value2);
    }
}

