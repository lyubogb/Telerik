
//03.
// A company has name, address, phone number, fax number, web site and manager. 
// The manager has first name, last name, age and a phone number. 
// Write a program that reads the information about a company and its manager
// and prints them on the console.

using System;
using System.Text;

class CompanyInformation
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Enter company name : ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address : ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter company phone number : ");
        uint companyTelNumber = uint.Parse(Console.ReadLine());
        Console.Write("Enter company fax number : ");
        uint companyFaxNumber = uint.Parse(Console.ReadLine());
        Console.Write("Enter company web site : ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Enter manager first name : ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager last name : ");
        string managerLastName = Console.ReadLine();
        string managerName = managerFirstName + " " + managerLastName;
        Console.Write("Enter manager age : ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Enter manager phone number : ");
        uint managerPhoneNumber = uint.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("===============COMPANY=INFORMATYON===============");
        Console.WriteLine("Company name : {0} ", companyName);
        Console.WriteLine("Company address : {0}", companyAddress);
        Console.WriteLine("Company phone number : {0}", companyTelNumber);
        Console.WriteLine("Company fax number : {0}", companyFaxNumber);
        Console.WriteLine("Company web site : {0}", companyWebSite);
        Console.WriteLine();
        Console.WriteLine("=================COMPANY=MANAGER=================");
        Console.WriteLine("Manager full name : {0}", managerName);
        Console.WriteLine("Manager age : {0}", managerAge);
        Console.WriteLine("Manager phone number : {0}", managerPhoneNumber);
        Console.ReadKey();
    }
}