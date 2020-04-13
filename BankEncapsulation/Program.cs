using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            var amount = 300;
            account.Deposit(amount);
            account.GetBalance();
            Console.WriteLine($"Balance = {account.GetBalance()}");
        }
    }
}
