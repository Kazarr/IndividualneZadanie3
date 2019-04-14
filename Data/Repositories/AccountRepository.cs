using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class AccountRepository:MyConnection
    {
        public Account LoadAccount(int clientId)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT * FROM Account where Id = @Pattern";
                        command.Parameters.Add("@Pattern", SqlDbType.Int).Value = clientId;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds, "Account");
                            DataTable dt = ds.Tables["Account"];

                            int id = int.Parse(ds.Tables["Account"].Rows[0][0].ToString());
                            int idClient = int.Parse(ds.Tables["Account"].Rows[0][1].ToString());
                            int idBank = int.Parse(ds.Tables["Account"].Rows[0][2].ToString());
                            DateTime CreationDate = DateTime.Parse(ds.Tables["Account"].Rows[0][3].ToString());
                            //DateTime ExpireDate = DateTime.Parse(ds.Tables["Account"].Rows[0][4].ToString());
                            decimal amount = decimal.Parse(ds.Tables["Account"].Rows[0][5].ToString());
                            string IBAN = ds.Tables["Account"].Rows[0][6].ToString();
                            decimal ActualOverFlow = decimal.Parse(ds.Tables["Account"].Rows[0][7].ToString());
                            decimal OverFlowLimit = decimal.Parse(ds.Tables["Account"].Rows[0][8].ToString());

                            return new Account(id,idClient, idBank, CreationDate,amount,IBAN,ActualOverFlow,OverFlowLimit);
                        }
                    }
                }catch(Exception e)
                {
                    throw;
                }
            }
            //return null;
        }
        public bool UpdateAccountOverFlowLimit(Account account)
        {
            using(SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"UPDATE Account
                                                SET OverFlowLimit = @OverFlowLimit
                                                WHERE Id = @Id";
                        command.Parameters.Add("@OverFlowlimit", SqlDbType.Decimal).Value = account.OverFlowLimit;
                        command.Parameters.Add("Id", SqlDbType.Int).Value = account.Id;
                        if (command.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }catch(Exception e)
                {
                    throw;
                }
            }
        }
        public bool InsertAccount(Account account)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO Account (Id_Client, Id_Bank, Iban)
                                                VALUES (@IdClient, 1, @Iban)";
                        command.Parameters.Add("@IdClient", SqlDbType.Int).Value = account.IdClient;
                        command.Parameters.Add("@Iban", SqlDbType.VarChar).Value = account.IBAN;
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
        public bool UpdateAccountAmount(Account account)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"update Account 
                                                set account.Amount =  account.Amount + (select top 1 case 
										                                                when t.[TypeTransaction] = 'W' then t.Amount * (-1) 
										                                                else t.Amount
										                                                end
										                                                from [Transaction] as t
										                                                JOIN AccountTransaction as act 
										                                                ON t.Id = act.Id_Transaction
										                                                WHERE act.Id_DestinationAccount = 6 OR act.Id_Account = 6
										                                                ORDER BY t.Id desc)
                                                where id = @Id";
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = account.Id;
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
    }
}
