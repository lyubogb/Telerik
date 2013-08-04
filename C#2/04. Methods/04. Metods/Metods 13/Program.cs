// 13.
// Write a program that can solve these tasks:
//      Reverses the digits of a number
//      Calculates the average of a sequence of integers
//      Solves a linear equation a * x + b = 0
//      Create appropriate methods.
//      Provide a simple text-based menu for the user to choose which task to solve.
//      Validate the input data:
//      The decimal number should be non-negative
//      The sequence should not be empty
//      a should not be equal to 0

// Напишете програма, която може да реши тези задачи:
//      Обръща цифрите на редица
//      Изчислява средната стойност на последователност от числа
//      Решава линейно уравнение A * X + б = 0
//          Създайте подходящи методи.
//          Използвайте просто текстово потребителско меню за избор на задача за решаване.
//          Проверка на входните данни:
//              Десетичното число трябва да бъде неотрицателно
//              Поредицата трябва да съдържа поне един член
//              А трябва да бъде различна от 0

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1-Reverses the digits of a number.");
            Console.WriteLine("2-Calculates the average of a sequence of integers.");
            Console.WriteLine("3-Solves a linear equation a * x + b = 0");
            Console.Write("Your choise: ");
            int choise = int.Parse(Console.ReadLine());
            int number = 0;
            switch (choise)
            {
                case 1:
                    {
                        Console.WriteLine();
                        bool comp;
                        string strNumber = null;
                        do
                        {
                            comp = false;
                            number = 0;
                            Console.WriteLine("Enter Your positive number");
                            if (int.TryParse(strNumber = Console.ReadLine(), out number) && number >= 0)
                            {
                                Console.WriteLine("Valid number: {0}", strNumber);
                            }
                            else
                            {
                                comp = true;
                                Console.WriteLine("Invalid number: {0}", strNumber);
                            }
                        } while (comp == true);
                        Console.WriteLine("Revers number is: " + Revers(strNumber));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine();
                        Console.Write("Please enter number of integers: ");
                        int n = int.Parse(Console.ReadLine());
                        int[] array = new int[n];
                        bool comp;
                        string strNumber = null;

                        for (int i = 0; i < n; i++)
                        {
                            number = 0;
                            do
                            {
                                comp = false;

                                Console.Write("Enter array {0} ==> ", i);
                                if (int.TryParse(strNumber = Console.ReadLine(), out number))
                                {
                                    Console.WriteLine("Valid number: {0}", strNumber);
                                }
                                else
                                {
                                    comp = true;
                                    Console.WriteLine("Invalid number: {0}", strNumber);
                                }
                            } while (comp == true);
                            array[i] = number;
                        }

                        Console.WriteLine("Average of sequence is : {0}", Average(array));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a and b");
                        decimal a = 0;
                        decimal b = 0;
                        decimal num = 0;
                        bool comp;
                        string strNumber = null;
                        do
                        {
                            comp = false;
                            number = 0;
                            Console.Write("a = ");
                            if (decimal.TryParse(strNumber = Console.ReadLine(), out num) && num != 0)
                            {
                                Console.WriteLine("Valid number: {0}", strNumber);
                            }
                            else
                            {
                                comp = true;
                                Console.WriteLine("Invalid number: {0}", strNumber);
                            }
                        } while (comp == true);
                        a = num;
                        do
                        {
                            comp = false;
                            number = 0;
                            Console.Write("b = ");
                            if (decimal.TryParse(strNumber = Console.ReadLine(), out num))
                            {
                                Console.WriteLine("Valid number: {0}", strNumber);
                            }
                            else
                            {
                                comp = true;
                                Console.WriteLine("Invalid number: {0}", strNumber);
                            }
                        } while (comp == true);
                        b = num;
                        Console.WriteLine("x = " + LinerEquation(a, b));
                        break;
                    }
                default: Console.WriteLine("Invalid choise.");
                    break;
            }
        }
    }
    static string Revers(string arr)
    {
        string buffer = null;
        for (int i = 0; i < arr.Length; i++)
        {
            buffer += arr[arr.Length - 1 - i];

        }
        return buffer;
    }
    static decimal Average(int[] arr)
    {
        decimal sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum / arr.Length;
    }
    static decimal LinerEquation(decimal a, decimal b)
    {
        return (-b / a);
    }
}