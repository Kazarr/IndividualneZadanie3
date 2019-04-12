using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ClientManagmentRepository:MyConnection
    {
        public DataSet LoadClientManagment(string pattern)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT CreationDate, ExpireDate, FirstName, LastName, Amount, IBAN, ActualOverFlow, OverFlowLimit FROM Account as a
                                                JOIN Client as c on a.Id_Client = c.id
                                                WHERE IdNumber = @IdNumber";
                        command.Parameters.Add("@IdNumber", SqlDbType.VarChar).Value = pattern;
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
