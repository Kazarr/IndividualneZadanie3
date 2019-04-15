using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class MyConnection
    {
        public SqlConnection Connection { get { return new SqlConnection(CONNECTION_STRING); } set{ } }
        private const string CONNECTION_STRING = @"Server=kardos\sqlexpresskardy;Database=BankSystem;Trusted_Connection=True";
    }
}
