using System;
using System.Collections.Generic;
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
        }

        public ClientRepository ClientRepository { get; set; }
        public bool FindClient(string pattern)
        {
            return ClientRepository.FindClientByIdNumber(pattern);

        }
    }
}
