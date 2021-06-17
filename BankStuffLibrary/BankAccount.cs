using System;
using System.Collections.Generic;
using System.Text;

namespace BankStuffLibrary

{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {

                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Ammount;
                }
                return balance;

            }
        }

        private static int accountNum = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();


        public BankAccount(string name, decimal initialBalance)

        {
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            this.Owner = name;
            this.Number = accountNum.ToString();
            accountNum++;
        }


        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be postive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawl(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawl must be positive");

            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficent funds for this withdrawl");
            }
            var withdrawl = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawl);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            //Header
            report.AppendLine("Date\t\tAmmount\tNote");
            foreach (var item in allTransactions)
            {     //Rows
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Ammount}\t{item.Notes}");
            }
            return report.ToString();
        }
    }
}
