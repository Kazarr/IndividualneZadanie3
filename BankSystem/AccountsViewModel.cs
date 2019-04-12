using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;

namespace BankSystem
{
    public class AccountsViewModel
    {
        private AccountRepository _accountRepository { get; set; }

        public DataSet LoadAccounts()
        {
            return _accountRepository.LoadAccount();
        }
    }
}
