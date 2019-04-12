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

        public Client(int id, string firstName, string lastName, string adress, string idNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;
            IdNumber = idNumber;
        }

        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Adress { get; private set; }
        public string IdNumber { get; private set; }
    }
}
