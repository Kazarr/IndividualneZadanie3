using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class City
    {
        public City()
        {
        }

        public City(int id, string name, string postalCode)
        {
            Id = id;
            Name = name;
            PostalCode = postalCode;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string PostalCode { get; private set; }
    }
}
