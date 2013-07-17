using System;

class HowOldYouWillBeAfter10Years
{
    static void Main()
    {
        string text;
        int age = 0;
        Console.WriteLine("How old are you?");
        age = int.Parse(Console.ReadLine());
        text = "Now You are " + age + " years old, but after 10 year You will be " + (age + 10) + " years old.";
        Console.WriteLine(text);
        //Console.WriteLine("You was born {0}" + " .", (DateTime.Now.Year - age));
        Console.WriteLine(age);
    }
}
