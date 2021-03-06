﻿using System;
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

        //public DataSet LoadClient()
        //{
        //    using (base.Connection)
        //    {
        //        try
        //        {
        //            base.Connection.Open();
        //            using (SqlCommand command = new SqlCommand())
        //            {
        //                command.Connection = base.Connection;
        //                command.CommandText = @"SELECT * FROM Client";
        //                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //                {
        //                    DataSet ds = new DataSet();
        //                    adapter.Fill(ds, "Account");
        //                    DataTable dt = ds.Tables["Account"];
        //                    return ds;
        //                }
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            throw;
        //        }
        //    }
        //}

            /// <summary>
            /// Loads client into transaction view model
            /// </summary>
            /// <param name="account"></param>
            /// <returns></returns>
        public Client LoadClient(Account account)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"  SELECT * FROM Client as c
                                                 join Account as a on c.id = a.Id_Client
                                                 WHERE a.Id = @IdAccount";
                        command.Parameters.Add("@IdAccount", SqlDbType.VarChar).Value = account.Id;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int clienId = reader.GetInt32(0);
                                string firstName = reader.GetString(1);
                                string lastname = reader.GetString(2);
                                string adress = reader.GetString(3);
                                int idCity = reader.GetInt32(4);
                                string idNumber = reader.GetString(5);
                                return new Client(clienId, firstName, lastname, adress, idCity, idNumber);
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

        /// <summary>
        /// Loads client into account view model
        /// </summary>
        /// <param name="idClient"></param>
        /// <returns></returns>
        public Client LoadClient(int idClient)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT * FROM Client WHERE Id = @IdClient";
                        command.Parameters.Add("@IdClient", SqlDbType.VarChar).Value = idClient;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int clienId = reader.GetInt32(0);
                                string firstName = reader.GetString(1);
                                string lastname = reader.GetString(2);
                                string adress = reader.GetString(3);
                                int idCity = reader.GetInt32(4);
                                string idNumber = reader.GetString(5);
                                return new Client(clienId, firstName, lastname, adress, idCity, idNumber);
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
        /// <summary>
        /// Used when you update client info
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public bool UpdateClient(Client client)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"UPDATE Client
                                                SET FirstName = @FirstName,
                                                    LastName = @LastName,
                                                    Adress = @Adress,
                                                    IdNumber = @IdNumber
                                                WHERE Id = @IdClient";
                        command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = client.FirstName;
                        command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = client.LastName;
                        command.Parameters.Add("@Adress", SqlDbType.NVarChar).Value = client.Adress;
                        command.Parameters.Add("@IdNumber", SqlDbType.VarChar).Value = client.IdNumber;
                        command.Parameters.Add("@IdClient", SqlDbType.Int).Value = client.Id;
                        if (command.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// Used when inserting new clinet
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public int InsertClient(Client client)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO Client (FirstName, LastName, Adress, Id_City ,IdNumber)
                                                OUTPUT INSERTED.Id
                                                VALUES (@Firstname, @LastName, @Adress, @Id_City, @IdNumber)";
                        command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = client.FirstName;
                        command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = client.LastName;
                        command.Parameters.Add("@Adress", SqlDbType.NVarChar).Value = client.Adress;
                        command.Parameters.Add("@Id_City", SqlDbType.Int).Value = client.IdCity;
                        command.Parameters.Add("@IdNumber", SqlDbType.VarChar).Value = client.IdNumber;
                        return (int)command.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Finds client by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Finds client by idnumber
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Returns client based on IBAN
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public Client GetClientByIdIban(string pattern)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT c.id, c.firstname, c.lastname, c.adress, c.id_city, c.idNumber FROM Client as c 
                                                join account as a on c.id = a.id_client
                                                WHERE a.iban = @pattern";
                        command.Parameters.Add("@pattern", SqlDbType.VarChar).Value = pattern;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int clienId = reader.GetInt32(0);
                                string firstName = reader.GetString(1);
                                string lastname = reader.GetString(2);
                                string adress = reader.GetString(3);
                                int idCity = reader.GetInt32(4);
                                string idNumber = reader.GetString(5);
                                return new Client(clienId, firstName, lastname, adress, idCity, idNumber);
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
        /// <summary>
        /// Finds client based on first name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Finds client based on last name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
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
        


    }
}
