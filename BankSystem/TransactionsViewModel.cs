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
        private Transaction _transaction;
        private TransactionRepository _transactionRepository;

        public TransactionsViewModel()
        {
            _transactionRepository = new TransactionRepository();
            _account = new Account();
        }

        public DataSet LoadAllTransactions()
        {
            return _transactionRepository.LoadAllTransactions();
        }

        public DataSet LoadClientTransactions(int accountId)
        {
            return _transactionRepository.LoadAllTransactions(accountId);
        }
        public void Deposit(int amount, int accountId)
        {
            _transaction = new Transaction();
            _transaction.Amount = amount;
            _transaction.TypeTransaction = 'D';
            _account = new Account();
            _account.Id = accountId;

            _transaction.Id = _transactionRepository.Deposit(_transaction);
            _transactionRepository.AccountDeposit(_transaction,_account.Id);
        }
        public void Withdrawal(int amount, int accoundId)
        {
            _transaction = new Transaction();
            _transaction.Amount = amount;
            _transaction.TypeTransaction = 'W';
            _account = new Account();
            _account.Id = accoundId;

            _transaction.Id =_transactionRepository.Withdrawal(_transaction);
            _transactionRepository.AccountWithdrawal(_transaction, _account.Id);
        }
    }
}
