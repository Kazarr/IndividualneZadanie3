using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace BankSystem
{
    public class TransactionsViewModel
    {
        private Account _account;
        private TransactionRepository _transactionRepository;

        public TransactionsViewModel()
        {
            _transactionRepository = new TransactionRepository();

        }

        public DataSet LoadAllTransactions()
        {
            return _transactionRepository.LoadAllTransactions();
        }

        public DataSet LoadClientTransactions(int accountId)
        {
            return _transactionRepository.LoadAllTransactions(accountId);
        }
    }
}
