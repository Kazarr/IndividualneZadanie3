using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Account
    {
        public Account()
        {
        }

        public Account(int id, DateTime creationDate, DateTime expireDate, decimal amount, string iBAN, decimal actualOverFlow, decimal overFlowLimit)
        {
            Id = id;
            CreationDate = creationDate;
            ExpireDate = expireDate;
            Amount = amount;
            IBAN = iBAN;
            ActualOverFlow = actualOverFlow;
            OverFlowLimit = overFlowLimit;
        }

        public int Id { get; private set; }
        public DateTime CreationDate { get; private set; }
        public DateTime ExpireDate { get; set; }
        public decimal Amount { get; set; }
        public string IBAN { get; private set; }
        public decimal ActualOverFlow { get; set; }
        public decimal OverFlowLimit { get; set; }
    }
}
