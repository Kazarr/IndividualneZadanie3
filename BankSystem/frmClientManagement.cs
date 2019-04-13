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
    public partial class frmClientManagement : Form
    {
        private string _pattern;
        private int _accountId;
        public ClientManagmentViewModel ClientManagmentViewModel { get; set; }

        /// <summary>
        /// Backup, do not really use :)
        /// </summary>
        //public frmClientManagement() : this(0) { }

        /// <summary>
        /// Used when viewing/updating existing client.
        /// </summary>
        /// <param name="clientId"></param>
        public frmClientManagement(string pattern)
        {
            InitializeComponent();
            _pattern = pattern;
            ClientManagmentViewModel = new ClientManagmentViewModel();
            dgvAccount.DataSource = ClientManagmentViewModel.LoadInfo(_pattern);
            dgvAccount.DataMember = "Account";
            dgvAccount.Columns["Id"].Visible = false;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount(_accountId))
            {
                newForm.ShowDialog();
                if(newForm.DialogResult == DialogResult.OK)
                {
                    dgvAccount.DataSource = ClientManagmentViewModel.LoadInfo(_pattern);
                    dgvAccount.DataMember = "Account";
                    dgvAccount.Columns["Id"].Visible = false;
                }
            }
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdWithdrawal_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions(42))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdNewTransaction_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdCloseAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hodor?", "Hodor!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void dgvAccount_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _accountId = (int)dgvAccount.Rows[0].Cells[0].Value;
        }
    }
}
