using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;

namespace BankSystem
{
    public class ClientManagmentViewModel
    {
        public ClientManagmentRepository ClientManagmentRepository { get; set; }

        public ClientManagmentViewModel()
        {
            ClientManagmentRepository = new ClientManagmentRepository();
        }

        public DataSet LoadClientManagment(string pattern)
        {
            return ClientManagmentRepository.LoadClientManagment(pattern);
        }
        public DataSet LoadUpdatedClientManagment(int accountId)
        {
            return ClientManagmentRepository.LoadUpdatedClientManagment(accountId);
        }

        //public void UpdateInfo(int idAccount, int idClient, decimal overFlowLimit, string firstName, string lastName, string adress, string cityName, string postalCode, string IdNumber)
        //{
        //    ClientManagmentRepository.SaveClientManagment(idAccount, idClient, overFlowLimit, firstName, lastName, adress, cityName, postalCode, IdNumber);
        //}
    }
}
