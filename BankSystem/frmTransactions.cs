using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmTransactions : Form
    {
        private TransactionsViewModel _transactionViewModel;
        /// <summary>
        /// Used when viewing all transactions.
        /// </summary>
        public frmTransactions()
        {
            InitializeComponent();
            _transactionViewModel = new TransactionsViewModel();
            dgvTransactions.DataSource = _transactionViewModel.LoadAllTransactions();
            dgvTransactions.DataMember = "Transactions";
        }

        /// <summary>
        /// Used when viewing selected client's transactions.
        /// </summary>
        /// <param name="accountId"></param>
        public frmTransactions(int accountId)
        {
            InitializeComponent();
            _transactionViewModel = new TransactionsViewModel();
            dgvTransactions.DataSource = _transactionViewModel.LoadClientTransactions(accountId);
            dgvTransactions.DataMember = "Transactions";
        }
    }
}
