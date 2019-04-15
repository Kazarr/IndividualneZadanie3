using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;

namespace BankSystem
{
    public class MainViewModel
    {
        private AccountRepository _accountRepository;
        public MainViewModel()
        {
            ClientRepository = new ClientRepository();
            _accountRepository = new AccountRepository();
        }

        public ClientRepository ClientRepository { get; set; }
        public bool FindClient(string pattern)
        {
            return ClientRepository.FindClientByIdNumber(pattern);

        }
        public DataSet GetMaxMoneyClients()
        {
            return _accountRepository.GetmaxMoneyClient();
        }

        public DataSet GetBankMoney()
        {
            return _accountRepository.GetBankMoney();
        }

        public DataSet GetAccountCount()
        {
            return _accountRepository.GetAccountCount();
        }
    }
}
