using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CardRepository:MyConnection
    {
        public DataSet LoadCards()
        {
            using (base.Connection)
            {
                try
                {
                    base.Connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = base.Connection;
                        command.CommandText = @"SELECT * FROM Card";
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds, "Card");
                            DataTable dt = ds.Tables["Card"];
                            return ds;
                        }
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
    }
}
