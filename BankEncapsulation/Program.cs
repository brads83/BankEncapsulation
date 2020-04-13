using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How much is your deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountToDeposit);
            account.GetBalance();
            Console.WriteLine($"Thank you! Your balance is now ${account.GetBalance()}");
        }
    }
}
