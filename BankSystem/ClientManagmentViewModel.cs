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
    public class ClientManagmentViewModel
    {
        private ClientManagmentRepository _clientManagmentRepository { get; set; }
        private CardRepository _cardRepository { get; set; }
        private AccountRepository _accountRepository { get; set; }
        private Card _card { get; set; }
        private Client _client { get; set; }
        private Account _account { get; set; }
        private Account _destinationAccount { get; set; }
        private Transaction _transaction { get; set; }
        //private string _iban { get; set; }

        public ClientManagmentViewModel()
        {
            _clientManagmentRepository = new ClientManagmentRepository();
            _cardRepository = new CardRepository();
            _accountRepository = new AccountRepository();
            _card = new Card();
            _client = new Client();
            _account = new Account();
            _transaction = new Transaction();
        }

        public DataSet LoadClientManagment(string pattern)
        {
            return _clientManagmentRepository.LoadClientManagment(pattern);
        }
        public DataSet LoadUpdatedClientManagment(int accountId)
        {
            return _clientManagmentRepository.LoadUpdatedClientManagment(accountId);
        }

        public DataSet LoadCards(int accountId)
        {
            return _cardRepository.LoadCards(accountId);
        }

        public void InsertRandomCard(int accoutnId)
        {
            Random r = new Random();
            _card.Id_Account = accoutnId;
            _card.Number = r.Next(Int32.MaxValue);
            _card.Pin = r.Next(0, 10000).ToString();
            _card.Id = _cardRepository.InsertCard(_card);
        }
        public void UpdateCard(int accountId, int cardId)
        {
            _card.Id_Account = accountId;
            _card.Id = cardId;
            _cardRepository.UpdateCard(_card);
        }
        public void UpdateAccountAmount()
        {
            _accountRepository.UpdateAccountAmount(_account);
        }

        public void SetAccountId(int id)
        {
            _account.Id = id;
        }
    }
}
