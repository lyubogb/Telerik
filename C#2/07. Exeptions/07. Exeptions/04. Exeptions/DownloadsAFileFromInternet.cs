
// 04.
// Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
// and stores it the current directory. Find in Google how to download files in C#. 
// Be sure to catch all exceptions and to free any used resources in the finally block.


using System;
using System.Net;

class DownloadsAFileFromInternet
{
    static void Main()
    {
        Console.WriteLine("The program downloads a file from internet\n" +
                    "by given URL from the user.");
        using (WebClient client = new WebClient())
        {
            Console.Write("Enter URL address : ");
            string URL = Console.ReadLine();                // http://www.devbg.org/img/Logo-BASD.jpg;
            Console.Write("Enter destination address : ");  // F:\img.jpg
            string fileAddres =  Console.ReadLine();
            try
            {
                client.DownloadFile(URL, fileAddres);
                Console.Write("File successfully downloaded.");
            }
            catch (ArgumentNullException ae)
            {
                Console.WriteLine("The address parameter cant be null!");
                Console.Write(ae.Message);
            }
            catch (System.Net.WebException we)
            {
                Console.WriteLine("Invalid address!");
                Console.Write(we.Message);
            }
            catch(System.NotSupportedException nse)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
                Console.Write(nse.Message);
            }
            finally
            {
                Console.WriteLine("  Bye. ");
            }
        }
    }
}