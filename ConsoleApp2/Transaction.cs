using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBank

{
    class Transaction
    {

        public decimal Ammount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal ammount, DateTime date, string note)
        {
            this.Ammount = ammount;
            this.Date = date;
            this.Notes = note;
        }


    }
}
