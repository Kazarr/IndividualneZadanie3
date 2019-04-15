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
        public Account Account { get; set; }
        public Client Client { get; set; }
        public Account DestinationAccount { get; set; }
        public Transaction Transaction { get; set; }
        private TransactionRepository _transactionRepository;
        private AccountRepository _accountRepository;
        private ClientRepository _clientRepository;

        public TransactionsViewModel()
        {
            _transactionRepository = new TransactionRepository();
            _accountRepository = new AccountRepository();
            _clientRepository = new ClientRepository();
            Transaction = new Transaction();
            DestinationAccount = new Account();
            Account = new Account();
            Client = new Client();
        }

        public TransactionsViewModel(Account account)
        {
            _transactionRepository = new TransactionRepository();
            Account = account;
            _accountRepository = new AccountRepository();
            Transaction = new Transaction();
            DestinationAccount = new Account();
            _clientRepository = new ClientRepository();
            Client = new Client();
            Client = _clientRepository.LoadClient(account);

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
            Transaction = new Transaction();
            Transaction.Amount = amount;
            Transaction.TypeTransaction = 'D';
            Account = new Account();
            Account.Id = accountId;

            Transaction.Id = _transactionRepository.Deposit(Transaction);
            _transactionRepository.AccountDeposit(Transaction,Account.Id);
        }
        public void Withdrawal(int amount, int accoundId)
        {
            Transaction = new Transaction();
            Transaction.Amount = amount;
            Transaction.TypeTransaction = 'W';
            Account = new Account();
            Account.Id = accoundId;

            Transaction.Id =_transactionRepository.Withdrawal(Transaction);
            _transactionRepository.AccountWithdrawal(Transaction, Account.Id);
        }
        public int FindAccountByIban(string iban)
        {
            return _accountRepository.FindAccountIdByIban(iban);
        }
        public void InsertTransaction(int amount,int accountId, int destinationAccountId)
        {
            Transaction.Amount = amount;
            Transaction.TypeTransaction = 'T';
            Transaction.Id = _transactionRepository.InsertTransaction(Transaction);
            _transactionRepository.InsertAccountTransaction(Transaction.Id, accountId, destinationAccountId);
            Account.Id = accountId;
            DestinationAccount.Id = destinationAccountId;
            _accountRepository.UpdateSourceAccountAmount(Account);
            _accountRepository.UpdateDestinationAccountAmount(DestinationAccount);
        }
    }
}
