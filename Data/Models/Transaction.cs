using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Transaction
    {
        public Transaction()
        {
        }

        public Transaction(int id, decimal amount, DateTime creationDate, DateTime executeDate, int vS, int kS, int sS)
        {
            Id = id;
            Amount = amount;
            CreationDate = creationDate;
            ExecuteDate = executeDate;
            VS = vS;
            KS = kS;
            SS = sS;
        }

        public int Id { get; private set; }
        public decimal Amount { get; set; }
        public DateTime CreationDate { get; private set; }
        public DateTime ExecuteDate { get; set; }
        public int VS { get; set; }
        public int KS { get; set; }
        public int SS { get; set; }
    }
}
