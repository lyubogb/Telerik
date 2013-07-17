
// 11.
// Write a program that prints all possible cards from a standard deck of 52 cards 
// (without jokers). The cards should be printed with their English names. 
// Use nested for loops and switch-case.
///////////////////////    long variant    ////////////////////////

using System;

class PrintCardsNames
{
    static void Main()
    {
        string[] cards = { " 2 ", " 3 ", " 4 ", " 5 ", " 6 ", " 7 ", " 8 ", " 9 ", "10 ", " J ", " D ", " K ", " A " };
        string t = null; //= { "Clubs", "Diamonds", "Hearts", "Spades" };

        for (int u = 0; u <= 12; u++)
        {
            for (int v = 0; v < 4; v++)
            {
                switch (v)
                {
                    case 0: t = "Clubs";
                        break;
                    case 1: t = "Diamonds";
                        break;
                    case 2: t = "Hearts";
                        break;
                    case 3: t = "Spades";
                        break;
                }
                Console.WriteLine(cards[u] + t);
            }
        }
    }
}

//// 11.
//// Write a program that prints all possible cards from a standard deck of 52 cards 
//// (without jokers). The cards should be printed with their English names. 
//// Use nested for loops and switch-case.
/////////////////////////    short variant    ///////////////////////////

//using System;

//class PrintCardsNames
//{
//    static void Main()
//    {
//        string[] cards = { " 2 ", " 3 ", " 4 ", " 5 ", " 6 ", " 7 ", " 8 ", " 9 ", "10 ", " J ", " D ", " K ", " A " };
//        string[] type = { "Clubs", "Diamonds", "Hearts", "Spades" };
//        foreach (var c in cards)
//        {
//            foreach (var t in type)
//            {
//                Console.WriteLine(c + t);
//            }
//        }
//    }
//}