using System;

class BankAccountVariables
{
    static void Main()
    {
        string firstName = null;
        string middleName = null;
        string lastName = null;
        decimal? balance = null;
        string bankName = null;
        string IBAN = null;
        string BICCode = null;
        decimal? cardBalance = null;
        string firstCreditCardNum = null;
        string secondCreditCardNum = null;
        string thirdCreditCardNum = null;
        
        firstName = "Ivan";
        middleName = "Ivanov";
        lastName = "Stoyanov";
        bankName = "CBCG";
        IBAN = "GB29 NWBK 6016 1331 9268 19";
        BICCode = "BNPABGSX";
        cardBalance = 15704;
        firstCreditCardNum = "E300X";
        secondCreditCardNum = "E1589J";
        thirdCreditCardNum = "E1235E";
        balance = (decimal)((int)cardBalance * 0.9);

        Console.WriteLine("Holder accound: {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Balance: {0}", balance);
        Console.WriteLine("Bank name: {0}",bankName);
        Console.WriteLine("IBAN: {0}", IBAN);
        Console.WriteLine("BIC code: {0}", BICCode);
        Console.WriteLine("First credit card number: {0}", firstCreditCardNum);
        Console.WriteLine("Second credit card number : {0}", secondCreditCardNum);
        Console.WriteLine("Third credit card number : {0}", thirdCreditCardNum);
        Console.WriteLine("Card Balance: {0}", thirdCreditCardNum);
    }
}
