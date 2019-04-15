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
        public Card Card { get; set; }
        public Client Client { get; set; }
        public Account Account { get; set; }
        public Account DestinationAccount { get; set; }
        public Transaction Transaction { get; set; }

        public ClientManagmentViewModel(string idClientNumber)
        {
            _clientManagmentRepository = new ClientManagmentRepository();
            _cardRepository = new CardRepository();
            _accountRepository = new AccountRepository();
            Card = new Card();
            Client = new Client();
            Client.IdNumber = idClientNumber;
            Account = new Account();
            Transaction = new Transaction();
            Account = _accountRepository.LoadAccount(idClientNumber);
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
            Card.Id_Account = accoutnId;
            Card.Number = r.Next(Int32.MaxValue);
            Card.Pin = r.Next(0, 10000).ToString();
            Card.Id = _cardRepository.InsertCard(Card);
        }
        public void UpdateCard(int accountId, int cardId)
        {
            Card.Id_Account = accountId;
            Card.Id = cardId;
            _cardRepository.UpdateCard(Card);
        }
        public void UpdateAccountAmount()
        {
            _accountRepository.UpdateAccountAmount(Account);
        }

        public void SetAccountId(int id)
        {
            Account.Id = id;
        }
        public bool CloseAccount()
        {
            return _accountRepository.CloseAccount(Account);
        }
    }
}
