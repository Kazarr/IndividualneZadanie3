﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class TransactionRepository:MyConnection
    {
        public DataSet LoadTransactions()
        {
            using (base.Connection)
            {
                try
                {
                    base.Connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = base.Connection;
                        command.CommandText = @"SELECT * FROM Account";
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds, "Account");
                            DataTable dt = ds.Tables["Account"];
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
