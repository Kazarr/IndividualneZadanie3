using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repositories
{
    public class ClientRepository:MyConnection
    {
        public DataSet LoadClient()
        {
            using (base.Connection)
            {
                try
                {
                    base.Connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = base.Connection;
                        command.CommandText = @"SELECT * FROM Client";
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
        public bool FindClientById(int id)
        {
            using (base.Connection)
            {
                try
                {
                    base.Connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = base.Connection;
                        command.CommandText = @"SELECT Count(1) FROM Client WHERE Id = @Id";
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                        if ((int)command.ExecuteScalar() > 0)
                        {
                            return true;
                        }
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return false;
        }
        public bool FindClientByIdNumber(string pattern)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT Count(1) FROM Client WHERE IdNumber = @pattern";
                        command.Parameters.Add("@pattern", SqlDbType.VarChar).Value = pattern;

                        if ((int)command.ExecuteScalar() > 0)
                        {
                            return true;
                        }
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return false;
        }
        public bool FindClientByFirstName(string name)
        {
            using (base.Connection)
            {
                try
                {
                    base.Connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = base.Connection;
                        command.CommandText = @"SELECT Count(1) FROM Client WHERE FirstName LIKE @Name";
                        command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;

                        if ((int)command.ExecuteScalar() > 0)
                        {
                            return true;
                        }
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return false;
        }
        public bool FindClientByLastName(string name)
        {
            using (base.Connection)
            {
                try
                {
                    base.Connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = base.Connection;
                        command.CommandText = @"SELECT Count(1) FROM Client WHERE LastName LIKE @Name";
                        command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;

                        if ((int)command.ExecuteScalar() > 0)
                        {
                            return true;
                        }
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return false;
        }
        public Client GetClientById(int id)
        {
            using (base.Connection)
            {
                try
                {
                    base.Connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = base.Connection;
                        command.CommandText = @"SELECT * FROM Client WHERE Id = @Id";
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int clienId = reader.GetInt32(0);
                                string firstName = reader.GetString(1);
                                string lastname = reader.GetString(2);
                                string adress = reader.GetString(3);
                                string idNumber = reader.GetString(4);
                                return new Client(clienId, firstName, lastname, adress, idNumber);
                            }
                            else { throw new Exception("You dont have anything to read"); }
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
