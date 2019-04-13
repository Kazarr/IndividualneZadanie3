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
    public class CityRepository:MyConnection
    {
        public City LoadCity(int clientID)
        {
            using(SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT * FROM City WHERE Id = @ClientId";
                        command.Parameters.Add("@ClientId", SqlDbType.Int).Value = clientID;
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                string postalCode = reader.GetString(2);
                                return new City(id, name, postalCode);
                            }
                            else
                            {
                                throw new Exception("There was nothing to read");
                            }
                        }
                    }
                }catch(Exception e)
                {
                    throw;
                }
            }
        }
        public bool UpdateCity(City city)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"UPDATE City
                                                SET Name = @Name,
                                                    PostalCode = @PostalCode
                                                WHERE Id = @IdCity";
                        command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = city.Name;
                        command.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = city.PostalCode;
                        command.Parameters.Add("@IdCity", SqlDbType.Int).Value = city.Id;
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
        public int InsertCity(City city)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO City (Name, PostalCode)
                                                OUTPUT INSERTED.Id
                                                VALUES (@Name, @PostalCode)";
                        command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = city.Name;
                        command.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = city.PostalCode;
                        int ret = (int)command.ExecuteScalar();
                        return ret;
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
