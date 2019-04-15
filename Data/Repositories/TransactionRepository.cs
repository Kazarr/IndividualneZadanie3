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
    public class TransactionRepository:MyConnection
    {
        /// <summary>
        /// Used in overview in all client transactions
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
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
                                                t.ExecuteDate, t.VS, t.SS, t.KS, case
                                                when t.TypeTransaction = 'W' then 'Withdrawal'
                                                when t.TypeTransaction = 'D' then 'Deposit' 
                                                when t.TypeTransaction = 'T' then 'Transaction'
                                                end as [TransactionType]
                                                from [Transaction] AS t
                                                full JOIN AccountTransaction AS act ON t.Id = act.Id_Transaction
                                                full JOIN Account AS a ON act.Id_Account = a.Id
                                                full JOIN Account AS da ON act.Id_DestinationAccount = da.Id
                                                WHERE act.Id_Account = @accountId OR act.Id_DestinationAccount = @accountId
                                                order by id desc";
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

        /// <summary>
        /// Used when adding Transaction between two accounts
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="accountId"></param>
        /// <param name="destinationAccountId"></param>
        /// <returns></returns>
        public bool InsertAccountTransaction(int transactionId, int accountId, int destinationAccountId)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO [AccountTransaction] (Id_Account, Id_DestinationAccount, Id_Transaction)
                                                VALUES (@Id_account, @Id_DestinationAccount, @Id_Transaction)";
                        command.Parameters.Add("@Id_account", SqlDbType.Decimal).Value = accountId;
                        command.Parameters.Add("@Id_DestinationAccount", SqlDbType.Char).Value = destinationAccountId;
                        command.Parameters.Add("@Id_Transaction", SqlDbType.Char).Value = transactionId;
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
        /// Inserting transaction between two accounts
        /// Yea i know it could be one method
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public int InsertTransaction(Transaction transaction)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO [Transaction] (Amount, TypeTransaction, VS, SS, KS)
                                                OUTPUT INSERTED.Id
                                                VALUES (@Amount, @TypeTransaction, @VS, @SS, @KS)";
                        command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = transaction.Amount;
                        command.Parameters.Add("@TypeTransaction", SqlDbType.Char).Value = transaction.TypeTransaction;
                        command.Parameters.Add("@VS", SqlDbType.Int).Value = transaction.VS;
                        command.Parameters.Add("@SS", SqlDbType.Int).Value = transaction.SS;
                        command.Parameters.Add("@KS", SqlDbType.Int).Value = transaction.KS;
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
        /// Inserting transaction witgdrawal
        /// yea i know it could be one method
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public int Withdrawal(Transaction transaction)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO [Transaction] (Amount, TypeTransaction)
                                                OUTPUT INSERTED.Id
                                                VALUES (@Amount, @TypeTransaction)";
                        command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = transaction.Amount;
                        command.Parameters.Add("@TypeTransaction", SqlDbType.Char).Value = transaction.TypeTransaction;
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
        /// inserting transactino deposit
        /// yea i know it could be one method
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public int Deposit(Transaction transaction)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO [Transaction] (Amount, TypeTransaction)
                                                OUTPUT INSERTED.Id
                                                VALUES (@Amount, @TypeTransaction)";
                        command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = transaction.Amount;
                        command.Parameters.Add("@TypeTransaction", SqlDbType.Char).Value = transaction.TypeTransaction;
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
        /// Letting know what transaction account should use to update his amount
        /// </summary>
        /// <param name="transaction"></param>
        /// <param name="desinationAccountId"></param>
        /// <returns></returns>
        public bool AccountDeposit(Transaction transaction, int desinationAccountId)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO AccountTransaction (Id_DestinationAccount, Id_Transaction)
                                                VALUES (@Id_Account, @Id_Transaction)";
                        command.Parameters.Add("@Id_Account", SqlDbType.Decimal).Value = desinationAccountId;
                        command.Parameters.Add("@Id_Transaction", SqlDbType.Char).Value = transaction.Id;
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
        /// Letting know what transaction account should use to update his amount
        /// </summary>
        /// <param name="transaction"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public bool AccountWithdrawal(Transaction transaction, int accountId)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO AccountTransaction (Id_Account, Id_Transaction)
                                                VALUES (@Id_Account, @Id_Transaction)";
                        command.Parameters.Add("@Id_Account", SqlDbType.Int).Value = accountId;
                        command.Parameters.Add("@Id_Transaction", SqlDbType.Int).Value = transaction.Id;
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
        /// Used in overview in all transactions
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Used when withdrawing from atm
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int InsertATMTransaction(int amount)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO [Transaction] (Amount, TypeTransaction)
                                                OUTPUT INSERTED.Id
                                                VALUES (@Amount, @TypeTransaction)";
                        command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                        command.Parameters.Add("@TypeTransaction", SqlDbType.Char).Value = 'W';
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
        /// Letting know what transaction account should use to update his amount after withdrawing from atm
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="idTransaction"></param>
        /// <returns></returns>
        public bool InsertATMAccountTransaction(int accountId, int idTransaction)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO [AccountTransaction] (Id_Account, Id_Transaction)
                                                OUTPUT INSERTED.Id
                                                VALUES (@Id_Account, @Id_Transaction)";
                        command.Parameters.Add("@Id_Account", SqlDbType.Int).Value = accountId;
                        command.Parameters.Add("@Id_Transaction", SqlDbType.Int).Value = idTransaction;
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
    }
}
