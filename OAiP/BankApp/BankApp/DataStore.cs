using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BankApp
{
    internal class DataStore
    {
        public static List<Depositor> Depositors { get; set; } = new List<Depositor>();
        public static List<BankAccount> Accounts { get; set; } = new List<BankAccount>();
        public static List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
