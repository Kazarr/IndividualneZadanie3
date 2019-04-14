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
        private int _cardId;
        bool deposit;
        private ClientManagmentViewModel _clientManagmentViewModel { get; set; }

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
            _clientManagmentViewModel = new ClientManagmentViewModel();
            dgvAccount.DataSource = _clientManagmentViewModel.LoadClientManagment(_pattern);
            dgvAccount.DataMember = "Account";
            _accountId = (int)dgvAccount.Rows[0].Cells[0].Value;
            _clientManagmentViewModel.SetAccountId(_accountId);

            dgvAccount.Columns["Id"].Visible = false;

            dgvCards.DataSource = _clientManagmentViewModel.LoadCards(_accountId);
            dgvCards.DataMember = "Card";
            _cardId = (int)dgvCards.Rows[0].Cells[0].Value;
            dgvCards.Columns["Id"].Visible = false;
            btnCloseCard.Enabled = false;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount(_accountId))
            {
                newForm.ShowDialog();
                if(newForm.DialogResult == DialogResult.OK)
                {
                    dgvAccount.DataSource = _clientManagmentViewModel.LoadUpdatedClientManagment(_accountId);
                    dgvAccount.DataMember = "Account";
                    dgvAccount.Columns["Id"].Visible = false;
                }
            }
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            deposit = true;
            using (frmTransaction newForm = new frmTransaction(_accountId, deposit))
            {
                newForm.ShowDialog();
                if(newForm.DialogResult == DialogResult.OK)
                {
                    _clientManagmentViewModel.UpdateAccountAmount();
                    dgvAccount.DataSource = _clientManagmentViewModel.LoadUpdatedClientManagment(_accountId);
                }
            }
        }

        private void cmdWithdrawal_Click(object sender, EventArgs e)
        {
            deposit = false;
            using (frmTransaction newForm = new frmTransaction(_accountId, deposit))
            {
                newForm.ShowDialog();
                if(newForm.DialogResult == DialogResult.OK)
                {
                    _clientManagmentViewModel.UpdateAccountAmount();
                    dgvAccount.DataSource = _clientManagmentViewModel.LoadUpdatedClientManagment(_accountId);
                }
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions(_accountId))
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

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            _clientManagmentViewModel.InsertRandomCard(_accountId);

            dgvCards.DataSource = _clientManagmentViewModel.LoadCards(_accountId);
            dgvCards.DataMember = "Card";
        }

        private void btnCloseCard_Click(object sender, EventArgs e)
        {
            _clientManagmentViewModel.UpdateCard(_accountId, _cardId);

            dgvCards.DataSource = _clientManagmentViewModel.LoadCards(_accountId);
            dgvCards.DataMember = "Card";
        }

        private void dgvCards_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _cardId = (int)dgvCards.Rows[e.RowIndex].Cells[0].Value;
            btnCloseCard.Enabled = true;
            
        }
    }
}
