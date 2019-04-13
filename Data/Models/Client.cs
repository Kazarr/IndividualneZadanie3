using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Client
    {
        public Client()
        {
        }

        public Client(int id, string firstName, string lastName, string adress, int idCity, string idNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;
            IdNumber = idNumber;
            IdCity = idCity;
        }

        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string IdNumber { get; set; }
        public int IdCity { get; set; }
    }
}
