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
        private AccountRepository _accountRepository;
        public WithdrawalViewModel(int idCard)
        {
            _idAccount = _accountRepository.FinAccountIdByCardId(_idCard);
        }
    }
}
