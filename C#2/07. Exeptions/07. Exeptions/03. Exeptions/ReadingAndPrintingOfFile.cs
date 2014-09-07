
// 03.
// Write a program that enters file name along with its full file path 
// (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
// Find in MSDN how to use System.IO.File.ReadAllText(…). 
// Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Text;

class ReadingAndPrintingOfFile
{
    static void Main()
    {
        Console.Write("Enter the full path of the file you want to read: ");
        string path = Console.ReadLine();
        Console.WriteLine("The content of the Your file is:");
        Console.WriteLine(ReadText(path));
    }
    static string ReadText(string path)
    {
        string text = null;
        try
        {
            text = File.ReadAllText(path);
           
        }
        catch (System.ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (System.ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }        
        catch (System.IO.PathTooLongException ptle)
        {
            Console.WriteLine(ptle.Message);
        }
        catch (System.IO.DirectoryNotFoundException dnfe)
        {
            Console.WriteLine(dnfe.Message);
        }
        catch (System.IO.FileNotFoundException fnfe)
        {
            Console.WriteLine(fnfe.Message);
        }
        catch (System.IO.IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        catch (System.UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }       
        catch (System.NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }
        catch (System.Security.SecurityException se)
        {
            Console.WriteLine(se.Message);
        }
        return text;
    }
}