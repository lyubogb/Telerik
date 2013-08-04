// 10.
// Write a program to calculate n! for each n in the range [1..100]. 
// Hint: Implement first a method that multiplies a number represented 
// as array of digits by given integer number. 
// Напишете прогряма за изчисляване на n! za някакво n в интервала [1..100].
// Съвет: Използвайте първият метод, който умножава едно число по броя
// 
using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{

    static void Main()
    {
        Console.Write("Enter Your number for calculating n! ==> ");
        int number = int.Parse(Console.ReadLine());

        BigInteger result = Factorial(number);
        Console.WriteLine("{0}! = {1}",number,result.ToString());
    }
    static BigInteger Factorial(int num)
    {
        BigInteger factorialResult = 1;

        for (int i = 2; i <= num; ++i)
        {
            factorialResult = i * factorialResult;
        }
        return factorialResult;
    }

}