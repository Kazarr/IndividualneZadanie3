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
    public class AccountsViewModel
    {
        private AccountRepository _accountRepository { get; set; }

        public AccountsViewModel()
        {
            _accountRepository = new AccountRepository();
        }

        public DataSet LoadAccounts(string idNumber, string firstName, string lastName)
        {
            return _accountRepository.LoadAccounts(idNumber, firstName, lastName);
        }
        public string LoadClientIdNumber(int accountId)
        {
            return _accountRepository.LoadIdNubmer(accountId);
        }
    }
}
