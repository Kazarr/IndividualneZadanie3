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
        public Account LoadAccount(int IdAccount)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT * FROM Account where Id = @IdAccount";
                        command.Parameters.Add("@IdAccount", SqlDbType.Int).Value = IdAccount;
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

        public Account LoadAccount(string idClientNumber)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT * FROM Account as a 
                                                Join Client as c on a.Id_client = c.id
                                                where c.IdNumber = @idClientNumber";
                        command.Parameters.Add("@idClientNumber", SqlDbType.VarChar).Value = idClientNumber;
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

                            return new Account(id, idClient, idBank, CreationDate, amount, IBAN, ActualOverFlow, OverFlowLimit);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }

        public bool CloseAccount(Account account)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"UPDATE Account
                                                SET ExpireDate = GETDATE()
                                                WHERE Id = @Id";
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
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }

        public int FinAccountIdByCardId(int idCard)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"select c.Id_Account from [Card] as c
                                                join Account as a on c.Id_Account =a.id
                                                where c.id = @id";
                        command.Parameters.Add("@id", SqlDbType.Int).Value = idCard;
                        return (int)command.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
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
                        command.CommandText = @"INSERT INTO Account (Id_Client, Id_Bank, Iban, OverFlowLimit)
                                                VALUES (@IdClient, 1, @Iban, @OverFlowLimit)";
                        command.Parameters.Add("@IdClient", SqlDbType.Int).Value = account.IdClient;
                        command.Parameters.Add("@Iban", SqlDbType.VarChar).Value = account.IBAN;
                        command.Parameters.Add("@OverFlowLimit", SqlDbType.VarChar).Value = account.OverFlowLimit;
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
										                                                WHERE act.Id_DestinationAccount = @Id OR act.Id_Account = @Id
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
        public bool UpdateSourceAccountAmount(Account account)
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
                                              set account.amount = account.amount - 
                                                                (select top 1 amount from [Transaction] as t
		                                                            join AccountTransaction as act on t.id = act.Id_Transaction
		                                                            where act.id_account = @Id
		                                                            order by t.id desc)
                                            where account.id = @Id";
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = account.Id;
                        if(command.ExecuteNonQuery() > 0)
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
        public bool UpdateDestinationAccountAmount(Account account)
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
                                              set account.amount = account.amount + 
                                                                (select top 1 amount from [Transaction] as t
		                                                            join AccountTransaction as act on t.id = act.Id_Transaction
		                                                            where act.Id_DestinationAccount = @Id
		                                                            order by t.id desc)
                                            where account.id = @Id";
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
        public int FindAccountIdByIban(string Iban)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT Id FROM Account WHERE Iban = @iban";
                        command.Parameters.Add("@iban", SqlDbType.VarChar).Value = Iban;
                        return (int)command.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
        public DataSet LoadAccounts(string idNumber, string firstName, string lastName)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT c.Id, c.Firstname, c.LastName, 
		                                        c.Adress, c.IdNumber, ct.Name, ct.PostalCode 
		                                        FROM client AS c
                                                JOIN city AS ct on c.Id_City = ct.Id
                                                WHERE c.IdNumber LIKE @IdNumber AND 
		                                        c.FirstName LIKE @FirstName AND 
		                                        c.LastName LIKE @LastName";
                        command.Parameters.Add("@IdNumber", SqlDbType.VarChar).Value = $"%{idNumber}%";
                        command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = $"%{firstName}%";
                        command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = $"%{lastName}%";
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
        public string LoadIdNubmer(int accountId)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"  select IdNumber from Account as a 
                                                  join Client as c on a.Id_Client = c.id
                                                  where a.id = @Id";
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = accountId;
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
