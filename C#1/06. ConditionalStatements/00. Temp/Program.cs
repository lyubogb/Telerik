using System;
class Program
{
    static void Main()
    {
        ////////////////////////////////////////////
        if (true)
        {

        }
        ////////////////////////////////////////////
        if (true)
        {

        }
        else
        {

        }
        ///////////////////////////////////////////
        if (true)
        {
            
        }
        else if (true)
        {
            
        }
        else
        {

        }
        ///////////////////////////////////////////
        int? switch_on = null;
        
        switch (switch_on)  // могат да бъдат от тип: int, char, bool, string
        {
            case null:
                {
                    
                    break;
                }
            case 01:
                {
                    Console.WriteLine();
                    break;
                }
            case 02:
                {
                    Console.WriteLine();
                    break;
                }
            case 06:                                                
            case 07:
            case 09:
                {   // 6, 7 и 9 ползват този блок

                    break;
                }

            default:
                {   // блок по подразбиране за всички за които липсват case блокове
                    Console.WriteLine();
                    break;
                }
        }

        DayOfWeek DDD = DayOfWeek.Sunday;


        switch (DDD)
        {
            case DayOfWeek.Monday:
                {
                    break;
                }
            case DayOfWeek.Sunday:
                {
                    Console.WriteLine();
                    break;
                }
            default:
                {
                    Console.WriteLine();
                    break;
                }
        }


        try
        {

        }
        catch (Exception)
        {

            throw;
        }
    }
}