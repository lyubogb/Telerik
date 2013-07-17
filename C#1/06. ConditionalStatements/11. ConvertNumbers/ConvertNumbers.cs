
// 10.
// Write a program that applies bonus scores to given scores in the range [1..9].
// The program reads a digit as an input. If the digit is between 1 and 3, the 
// program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; 
// if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value
// is not a digit, the program must report an error.
// Use a switch statement and at the end print the calculated new value in the console.



using System;


class Program
{
    static void Main()
    {

        do
        {
            string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            int H = 0;
            int number = int.Parse(Console.ReadLine());
            string printString = "";

            H = number;
            if (number > 99)
            {
                printString += ones[number / 100] + " hundred";
                if (number % 100 != 0)
                {
                    printString += " and ";
                }
                number %= 100;
            }

            if (number > 19)
            {
                printString += tens[number / 10 - 2];


                if (number % 10 != 0)
                {
                    printString += " ";
                }
                number %= 10;
            }

            if (number % 100 != 0)
                printString += ones[number];


            Console.WriteLine(H + " --> " + printString);
        } while (true);
    }
}

