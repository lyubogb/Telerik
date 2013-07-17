
// 13.
// * Write a program that calculates for given N how many trailing 
//   zeros present at the end of the number N!. Examples:
//   N = 10  N! = 3628800  2
//   N = 20  N! = 2432902008176640000  4
//   Does your program work for N = 50 000?
//   Hint: The trailing zeros in N! are equal to the number 
//   of its prime divisors of value 5. Think why!


using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int numberN;
        BigInteger result = 1;
        int zeros = 0;
        int divider = 5;
        bool xxx;
        do
        {
            Console.Write("Please enter uint number for N = ");
            xxx = int.TryParse(Console.ReadLine(), out numberN);
        } while (xxx == false|| numberN < 0);

        for (int i = 1; i <= numberN; i++)
        {
            result *= i;
        }

        Console.WriteLine("{0}! = {1}", numberN, result);

        //////////////////////// other slowly variant ////////////////////
        //while (result % 10 == 0)
        //{
        //    zeros++;
        //    result /= 10;
        //}


        while (numberN >= divider)
        {
            zeros += (numberN / divider);
            divider *= 5;
        }

        Console.Clear();
        Console.WriteLine("N = {0} / N! = {1} / ziros = {2}", numberN, result, zeros); //  N = 10  N! = 3628800  2
    }
}
