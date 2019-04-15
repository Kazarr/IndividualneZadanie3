using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformerBank
{
    public class WithdrawalViewModel
    {
        private int _idCard;
        private int _idAccount;
        private int _idTransaction;
        private Account _account;
        private AccountRepository _accountRepository;
        private TransactionRepository _transactionRepository;
        public WithdrawalViewModel(int idCard)
        {
            _accountRepository = new AccountRepository();
            _transactionRepository = new TransactionRepository();
            _account = new Account();
            _idCard = idCard;
            _idAccount = _accountRepository.FinAccountIdByCardId(_idCard);
            _account.Id = _idAccount;
        }
        public void Withdraw5()
        {
            _idTransaction = _transactionRepository.InsertATMTransaction(5);
            _transactionRepository.InsertATMAccountTransaction(_idAccount, _idTransaction);
            _accountRepository.UpdateAccountAmount(_account);
        }
        public void Withdraw10()
        {
            _idTransaction = _transactionRepository.InsertATMTransaction(10);
            _transactionRepository.InsertATMAccountTransaction(_idAccount, _idTransaction);
            _accountRepository.UpdateAccountAmount(_account);
        }
        public void Withdraw20()
        {
            _idTransaction = _transactionRepository.InsertATMTransaction(20);
            _transactionRepository.InsertATMAccountTransaction(_idAccount, _idTransaction);
            _accountRepository.UpdateAccountAmount(_account);
        }
        public void Withdraw50()
        {
            _idTransaction = _transactionRepository.InsertATMTransaction(50);
            _transactionRepository.InsertATMAccountTransaction(_idAccount, _idTransaction);
            _accountRepository.UpdateAccountAmount(_account);
        }
        public void Withdraw100()
        {
            _idTransaction = _transactionRepository.InsertATMTransaction(100);
            _transactionRepository.InsertATMAccountTransaction(_idAccount, _idTransaction);
            _accountRepository.UpdateAccountAmount(_account);
        }
        public void Withdraw200()
        {
            _idTransaction = _transactionRepository.InsertATMTransaction(200);
            _transactionRepository.InsertATMAccountTransaction(_idAccount, _idTransaction);
            _accountRepository.UpdateAccountAmount(_account);
        }
        public void Withdraw500()
        {
            _idTransaction = _transactionRepository.InsertATMTransaction(500);
            _transactionRepository.InsertATMAccountTransaction(_idAccount, _idTransaction);
            _accountRepository.UpdateAccountAmount(_account);
        }
    }
}
