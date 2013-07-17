using System;

class SquareOfTheNumber12345
{
    static void Main()
    {
        int number = 12345;  
        
        //При премахване на символите за коментар на долните два реда, числото се въвежда от клавиатурата
        //Console.Write("Въведете цяло число:");
        //number = int.Parse(Console.ReadLine());
        Console.WriteLine("Квадрата на числото {0} е: " + number*number + "\n\n", number);
    }
}

