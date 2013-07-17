
// 09.
// We are given 5 integer numbers. Write a program that checks 
// if the sum of some subset of them is 0. 
// Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;

class ChecksForZiroSum
{
    static void Main()
    {
        do
        {
            uint xxx = 5;    // members in the group
            int result = 0;
            ///////////////////////////////////////////////////////
            Console.Write("Enter value A = ");
            int valueA = int.Parse(Console.ReadLine());
            Console.Write("Enter value B = ");
            int valueB = int.Parse(Console.ReadLine());
            Console.Write("Enter value C = ");
            int valueC = int.Parse(Console.ReadLine());
            Console.Write("Enter value D = ");
            int valueD = int.Parse(Console.ReadLine());
            Console.Write("Enter value E = ");
            int valueE = int.Parse(Console.ReadLine());
            Console.WriteLine("============================================");
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            int[] numbers = { valueA, valueB, valueC, valueD, valueE };
            for (uint membersInGroup = 2; membersInGroup <= xxx; membersInGroup++) // members in the group
            {
                for (uint startAddres = 0; startAddres < xxx - (membersInGroup - 1); startAddres++) // start 
                {
                    result = 0;
                    for (uint addres = startAddres; addres < startAddres + membersInGroup; addres++)   // addres counter
                    {
                        result += numbers[addres];
                    }
                    ComparingAndPrint(result, membersInGroup, numbers, startAddres);
                }
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("============================================");
            Console.WriteLine();
        } while (true);


    }

    static void ComparingAndPrint(int result, uint membersInGroup, int[] numbers, uint startAddres)
    {


        if (result == 0)
        {
            switch (membersInGroup)
            {
                case 2:
                    {
                        Console.WriteLine("{0} + {1} = {2}", numbers[startAddres], numbers[startAddres + 1], result);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("{0} + {1} + {2}= {3}", numbers[startAddres], numbers[startAddres + 1], numbers[startAddres + 2], result);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("{0} + {1} + {2} + {3}= {4}", numbers[startAddres], numbers[startAddres + 1], numbers[startAddres + 2], numbers[startAddres + 3], result);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("{0} + {1} + {2} + {3} + {4}= {5}", numbers[startAddres], numbers[startAddres + 1], numbers[startAddres + 2], numbers[startAddres + 3], numbers[startAddres + 4], result);
                        break;
                    }

                default:
                    break;

            }

        }
    }
}
