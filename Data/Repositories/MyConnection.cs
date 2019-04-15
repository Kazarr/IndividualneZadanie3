using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{/// <summary>
/// Parent connection to DB. 
/// </summary>
    public class MyConnection
    {
        /// <summary>
        /// used by all repositories in connections
        /// PS. Chcel som aby dedeli celú connection aj s commandom. 
        /// a triedy  by si nastavili iba parametre a command text. 
        /// ale padalo mi to tak som to nechal najlepšie takto
        /// </summary>
        public SqlConnection Connection { get { return new SqlConnection(CONNECTION_STRING); } set{ } }
        /// <summary>
        /// connectino string to db
        /// </summary>
        private const string CONNECTION_STRING = @"Server=kardos\sqlexpresskardy;Database=BankSystem;Trusted_Connection=True";
    }
}
