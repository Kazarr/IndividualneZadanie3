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
        public ClientManagmentViewModel()
        {
            ClientManagmentRepository = new ClientManagmentRepository();
        }

        public ClientManagmentRepository ClientManagmentRepository { get; set; }
        public DataSet LoadInfo(string pattern)
        {
            return ClientManagmentRepository.LoadClientManagment(pattern);
        }
    }
}
