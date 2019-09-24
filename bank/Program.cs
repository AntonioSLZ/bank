using System;
using bank.Entities;
using bank.Entities.Exceptions;
using System.Globalization;

namespace bank
{
    public class Program
    {
        public static void Main()
        {

                Console.WriteLine("Enter account data");
                Console.Write("Number:");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder:");
                string holder = Console.ReadLine();
                Console.Write("Initial balance:");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("withdraw limit:");
                double withdrawlimit = double.Parse(Console.ReadLine());
                Account account = new Account(number, holder, balance, withdrawlimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw:");
                double amount = double.Parse(Console.ReadLine());
            try
            {
                account.WithDraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

        }
    }
}
