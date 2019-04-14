using System;
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
        public DataSet LoadAllTransactions(int accountId)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT t.Id, T.Amount, t.CreationDate,
                                                t.ExecuteDate, t.VS, t.SS, t.KS, da.IBAN from [Transaction] AS t
                                                JOIN AccountTransaction AS act ON t.Id = act.Id_Transaction
                                                JOIN Account AS a ON act.Id_Account = a.Id
                                                JOIN Account AS da ON act.Id_DestinationAccount = da.Id
                                                WHERE act.Id_Account = @accountId";
                        command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds, "Transactions");
                            DataTable dt = ds.Tables["Transactions"];
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

        public DataSet LoadAllTransactions()
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT * from [Transaction]";
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds, "Transactions");
                            DataTable dt = ds.Tables["Transactions"];
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
