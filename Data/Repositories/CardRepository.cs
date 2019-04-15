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
    public class CardRepository:MyConnection
    {
        public DataSet LoadCards(int accountId)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT Id, Number, DailyLimit, ExpireDate FROM Card WHERE Id_Account = @Id_Account";
                        command.Parameters.Add("@Id_Account", SqlDbType.Int).Value = accountId;
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
        public int InsertCard(Card card)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO Card (Id_Account, Number, Pin)
                                                OUTPUT INSERTED.Id
                                                VALUES (@Id_Account, @Number, @Pin)";
                        command.Parameters.Add("@Id_Account", SqlDbType.Int).Value = card.Id_Account;
                        command.Parameters.Add("@Number", SqlDbType.Int).Value = card.Number;
                        command.Parameters.Add("@Pin", SqlDbType.Char).Value = card.Pin;
                        return (int)command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
        public bool UpdateCard(Card card)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"UPDATE Card
                                                SET ExpireDate = GETDATE()
                                                WHERE Id = @Id";
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = card.Id;
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
        public string GetCardPin(int cardId)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"select Pin from Card where number = @number";
                        command.Parameters.Add("@number", SqlDbType.Int).Value = cardId;
                        return (string)command.ExecuteScalar();
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
