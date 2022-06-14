using System;

namespace Bank_USSD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount("Me", 1000000);

            bankAccount.DebitAmount(100);
            bankAccount.CreditAmount(10000);

            Console.WriteLine($"balance: {bankAccount._balance}");
        }
    }
}
