using System;
using System.Collections.Generic;

namespace HoneyBankUnited.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long? SavingsAccount { get; set; }
        public long? CheckingAccount { get; set; }
        public decimal? SavingsBalance { get; set; }
        public decimal? CheckingBalance { get; set; }
        public int? RoutingNumber { get; set; }
        public int? Compromised { get; set; }
    }
}
