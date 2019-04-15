using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
