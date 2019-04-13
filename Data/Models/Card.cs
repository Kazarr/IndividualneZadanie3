using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Card
    {
        public Card()
        {
        }

        public Card(int id, int number, int dailyLimit, DateTime expireDate, string pin)
        {
            Id = id;
            Number = number;
            DailyLimit = dailyLimit;
            ExpireDate = expireDate;
            Pin = pin;
        }

        public int Id { get; set; }
        public int Number { get; set; }
        public int DailyLimit { get; set; }
        public DateTime ExpireDate { get; private set; }
        public string Pin { get; set; }
        public int Id_Account { get; set; }
    }
}
