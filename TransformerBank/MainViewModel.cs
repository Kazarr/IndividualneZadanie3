using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace TransformerBank
{
    public class MainViewModel
    {
        private CardRepository _cardRepository;
        public MainViewModel()
        {
            _cardRepository = new CardRepository();
        }
        public bool Login(int cardId, string pin)
        {
            return _cardRepository.GetCardPin(cardId).Equals(pin);
        }
        public DateTime CardExpireDate(int cardId)
        {
            return _cardRepository.GetCardExpireDate(cardId);
        }
        public void CloseCard(Card card)
        {
            _cardRepository.UpdateCard(card);
        }
    }
}
