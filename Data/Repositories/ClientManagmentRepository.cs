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
        /// <summary>
        /// This is used when loading grid in client managment
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
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
                        command.CommandText = @"SELECT a.id, CreationDate, ExpireDate, FirstName, LastName, Amount, IBAN, ActualOverFlow, OverFlowLimit FROM Account as a
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

        //public void SaveClientManagment(decimal overFlowLimit, string firstName, string lastName, string adress, string cityName, string postalCodee, string IdNumber)
        //{
        //    using(SqlConnection connection = base.Connection)
        //    {
        //        try
        //        {
        //            connection.Open();
        //            using(SqlCommand command = new SqlCommand())
        //            {
        //                command.Connection = connection;
        //                command.CommandText = @"update Account
        //                                        set OverFlowLimit = @OverFlowLimit
        //                                        where ";
        //            }
        //        }catch(Exception e)
        //        {

        //        }
                
        //    }
        //}
        /// <summary>
        /// This is used when user update client or account info to load actual info
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public DataSet LoadUpdatedClientManagment(int accountId)
        {
            using (SqlConnection connection = base.Connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT a.id, CreationDate, ExpireDate, FirstName, LastName, Amount, IBAN, ActualOverFlow, OverFlowLimit FROM Account as a
                                                JOIN Client as c on a.Id_Client = c.id
                                                WHERE a.Id = @Id";
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = accountId;
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
