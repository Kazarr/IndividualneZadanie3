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
        private Account _destinationAccount;
        private Transaction _transaction;
        private TransactionRepository _transactionRepository;
        private AccountRepository _accountRepository;

        public TransactionsViewModel()
        {
            _transactionRepository = new TransactionRepository();
            _account = new Account();
            _accountRepository = new AccountRepository();
            _transaction = new Transaction();
            _destinationAccount = new Account();
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
        public int FindAccountByIban(string iban)
        {
            return _accountRepository.FindAccountIdByIban(iban);
        }
        public void InsertTransaction(int amount,int accountId, int destinationAccountId)
        {
            _transaction.Amount = amount;
            _transaction.TypeTransaction = 'T';
            _transaction.Id = _transactionRepository.InsertTransaction(_transaction);
            _transactionRepository.InsertAccountTransaction(_transaction.Id, accountId, destinationAccountId);
            _account.Id = accountId;
            _destinationAccount.Id = destinationAccountId;
            _accountRepository.UpdateSourceAccountAmount(_account);
            _accountRepository.UpdateDestinationAccountAmount(_destinationAccount);
        }
    }
}
