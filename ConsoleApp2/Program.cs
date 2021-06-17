using System;
using BankStuffLibrary;

namespace SuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Alex", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawl(120, DateTime.Now, "Hammock");
         

                account.MakeWithdrawl(50, DateTime.Now, "XBox game");
            

            Console.WriteLine(account.GetAccountHistory());


            ////Test for a negative balance;
            //try
            //{
            //    account.MakeWithdrawl(75000, DateTime.Now, "Attempt To OverDraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception Caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}
            




             
               //Test that initial balance must be positive.

            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);

            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught trying to create an account with a negative balance.");
            //    Console.WriteLine(e.ToString());

            //}

            
    }
}
    }
