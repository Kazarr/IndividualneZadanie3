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

        public Card(int id, int number, int dailyLimit, DateTime expireDate)
        {
            Id = id;
            Number = number;
            DailyLimit = dailyLimit;
            ExpireDate = expireDate;
        }

        public int Id { get; private set; }
        public int Number { get; private set; }
        public int DailyLimit { get; set; }
        public DateTime ExpireDate { get; private set; }
    }
}
