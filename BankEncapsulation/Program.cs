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

            var instance = new PersonalInformation();
            string number;
            long result;

            do
            {
                Console.WriteLine("Please enter your phone number, area code first");
                number = Console.ReadLine();
            } while (number.Length != 10 || !long.TryParse(number, out result));

            instance.NumberFormatted = number;
            Console.WriteLine(instance.NumberFormatted);

            /*Console.WriteLine("Please enter your phone number, area code first");
            instance.NumberFormatted = Console.ReadLine();
            Console.WriteLine(instance.NumberFormatted);*/
        }
    }
}
