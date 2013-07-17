/////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////    long variant    ///////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////

// 04. 
// Write a program that calculates N!/K! for given N and K (1<K<N).

//using System;
//using System.Numerics;

//class FactorielsExpression
//{
//    static void Main()
//    {
//        do
//        {
//            uint inputNumberK;
//            uint inputNumberN;
//            bool xxx;
//            decimal nFactoriel = 1;
//            decimal kFactoriel = 1;
//            decimal result = 1;
//            do
//            {
//                Console.Write("Enter K = ");
//                xxx = uint.TryParse(Console.ReadLine(), out inputNumberK);
//                if (xxx != true || 1 >= inputNumberK)
//                {
//                    Console.WriteLine("Entered number K must be uint number and 1<K. Enter new value");
//                    xxx = false;
//                }
//            } while (xxx == false);
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine("================================================");
//            Console.ResetColor();

//            do
//            {
//                Console.Write("Enter N = ");
//                xxx = uint.TryParse(Console.ReadLine(), out inputNumberN);
//                if (xxx != true || inputNumberK >= inputNumberN)
//                {
//                    Console.WriteLine("Entered number K must be uint number and K<N. Enter new value");
//                    xxx = false;
//                }
//            } while (xxx == false);
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine("================================================");
//            Console.ForegroundColor = ConsoleColor.Red;

//            for (uint i = 1; i <= inputNumberN; i++)
//            {
//                nFactoriel *= (i);
//            }
//            Console.WriteLine("N! = {0}", nFactoriel);
//            for (int i = 1; i <= inputNumberK; i++)
//            {
//                kFactoriel *= (i);
//            }
//            Console.WriteLine("K! = {0}", kFactoriel);
//            result = nFactoriel / kFactoriel;
//            Console.WriteLine("N!/K! = {0}", result);
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine("================================================");
//            Console.ResetColor();
//        } while (true);
//    }
//}


/////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////    short variant    //////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////


// 04. 
// Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class FactorielsExpression
{
    static void Main()
    {
        do
        {
            uint inputNumberK;
            uint inputNumberN;
            bool xxx;
            BigInteger nFactoriel = 1;

            //////////////////////Entering numbers///////////////////////////////////////
            do
            {
                Console.Write("Enter K = ");
                xxx = uint.TryParse(Console.ReadLine(), out inputNumberK);
                if (xxx != true || 1 >= inputNumberK)
                {
                    Console.WriteLine("Entered number K must be uint number and 1<=K. Enter new value");
                    xxx = false;
                }
            } while (xxx == false);
            ///////////////////////yelow line//////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("================================================");
            Console.ResetColor();
            ///////////////////////////////////////////////////////////////////////////
            do
            {
                Console.Write("Enter N = ");
                xxx = uint.TryParse(Console.ReadLine(), out inputNumberN);
                if (xxx != true || inputNumberK >= inputNumberN)
                {
                    Console.WriteLine("Entered number K must be uint number and K<N. Enter new value");
                    xxx = false;
                }
            } while (xxx == false);
            ///////////////////////yelow line & red text///////////////////////////////
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("================================================");
            Console.ForegroundColor = ConsoleColor.Red;
            ///////////////////////////////////////////////////////////////////////////
            for (uint i = inputNumberK + 1; i <= inputNumberN; i++)
            {
                nFactoriel *= (i);
            }
            ///////////////////////////////////////////////////////////////////////////
            Console.WriteLine("N!/K! = {0}", nFactoriel);
            ///////////////////////yelow line//////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("================================================");
            Console.ResetColor();
        } while (true);
    }
}