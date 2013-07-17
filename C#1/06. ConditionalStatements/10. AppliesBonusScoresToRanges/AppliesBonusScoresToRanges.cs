
// 10.
// Write a program that applies bonus scores to given scores in the range [1..9].
// The program reads a digit as an input. If the digit is between 1 and 3, the 
// program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; 
// if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value
// is not a digit, the program must report an error.
// Use a switch statement and at the end print the calculated new value in the console.

using System;

class AppliesBonusScoresToRanges
{
    static void Main()
    {
        Console.WriteLine("Enter integer number betwin 1-9.    ");
        int result = 1;
        int number;
        do
        {
            bool comp = int.TryParse((Console.ReadLine()), out number);


            if (comp == false || number <= 0 || number >= 10)
            {

                {
                    Console.WriteLine("Error");
                    result = 1;
                }
            }
            else
            {
                switch (number)
                {
                    case 1:
                    case 2:
                    case 3:
                        {
                            result *= 10;
                            break;
                        }
                    case 4:
                    case 5:
                    case 6:
                        {
                            result *= 100;
                            break;
                        }
                    case 7:
                    case 8:
                    case 9:
                        {
                            result *= 1000;
                            break;
                        }
                    default:
                        break;
                }
                Console.SetCursorPosition(30, Console.CursorTop - 1);
                Console.Write("{0,10}", result);
                Console.Write("\r");
            }

           

        } while (true);
    }
}