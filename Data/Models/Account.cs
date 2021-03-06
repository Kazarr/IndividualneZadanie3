﻿using System;
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

        public Account(int id, int idClient, int idBank, DateTime creationDate, decimal amount, string iBAN, decimal actualOverFlow, decimal overFlowLimit)
        {
            Id = id;
            CreationDate = creationDate;
            Amount = amount;
            IBAN = iBAN ?? throw new ArgumentNullException(nameof(iBAN));
            ActualOverFlow = actualOverFlow;
            OverFlowLimit = overFlowLimit;
            IdClient = idClient;
            IdBank = idBank;
        }

        public Account(int id, int idClient, int idBank, DateTime creationDate, DateTime expireDate, decimal amount, string iBAN, decimal actualOverFlow, decimal overFlowLimit)
        {
            Id = id;
            IdClient = idClient;
            IdBank = idBank;
            CreationDate = creationDate;
            ExpireDate = expireDate;
            Amount = amount;
            IBAN = iBAN;
            ActualOverFlow = actualOverFlow;
            OverFlowLimit = overFlowLimit;
        }

        public int Id { get; set; }
        public DateTime CreationDate { get; private set; }
        public DateTime ExpireDate { get; set; }
        public decimal Amount { get; set; }
        public string IBAN { get; set; }
        public decimal ActualOverFlow { get; set; }
        public decimal OverFlowLimit { get; set; }
        public int IdClient { get; set; }
        public int IdBank { get; set; }
    }
}
