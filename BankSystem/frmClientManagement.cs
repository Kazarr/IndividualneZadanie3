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
        //private string _pattern;
        //private int _accountId;
        //private int _cardId;
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
            _clientManagmentViewModel = new ClientManagmentViewModel(pattern);
            _clientManagmentViewModel.Client.IdNumber = pattern;
            //_pattern = pattern;
            dgvAccount.DataSource = _clientManagmentViewModel.LoadClientManagment(pattern);
            dgvAccount.DataMember = "Account";
            _clientManagmentViewModel.Account.Id = (int)dgvAccount.Rows[0].Cells[0].Value;
            //_accountId = (int)dgvAccount.Rows[0].Cells[0].Value;
            //_clientManagmentViewModel.SetAccountId(_accountId);

            dgvAccount.Columns["Id"].Visible = false;


            dgvCards.DataSource = _clientManagmentViewModel.LoadCards(_clientManagmentViewModel.Account.Id);
            //dgvCards.DataSource = _clientManagmentViewModel.LoadCards(_accountId);
            dgvCards.DataMember = "Card";

            if(dgvCards.Rows.Count != 0)
            {
                _clientManagmentViewModel.Card.Id = (int)dgvCards.Rows[0].Cells[0].Value;
                //_cardId = (int)dgvCards.Rows[0].Cells[0].Value;
                dgvCards.Columns["Id"].Visible = false;
                btnCloseCard.Enabled = false;
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount(_clientManagmentViewModel.Account.Id))
            {
                newForm.ShowDialog();
                if(newForm.DialogResult == DialogResult.OK)
                {
                    dgvAccount.DataSource = _clientManagmentViewModel.LoadUpdatedClientManagment(_clientManagmentViewModel.Account.Id);
                    dgvAccount.DataMember = "Account";
                    dgvAccount.Columns["Id"].Visible = false;
                }
            }
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            deposit = true;
            using (frmTransaction newForm = new frmTransaction(_clientManagmentViewModel.Account, deposit))
            {
                newForm.ShowDialog();
                if(newForm.DialogResult == DialogResult.OK)
                {
                    _clientManagmentViewModel.UpdateAccountAmount();
                    dgvAccount.DataSource = _clientManagmentViewModel.LoadUpdatedClientManagment(_clientManagmentViewModel.Account.Id);
                }
            }
        }

        private void cmdWithdrawal_Click(object sender, EventArgs e)
        {
            deposit = false;
            using (frmTransaction newForm = new frmTransaction(_clientManagmentViewModel.Account, deposit))
            {
                newForm.ShowDialog();
                if(newForm.DialogResult == DialogResult.OK)
                {
                    _clientManagmentViewModel.UpdateAccountAmount();
                    dgvAccount.DataSource = _clientManagmentViewModel.LoadUpdatedClientManagment(_clientManagmentViewModel.Account.Id);
                }
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions(_clientManagmentViewModel.Account.Id))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdNewTransaction_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction(_clientManagmentViewModel.Account))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdCloseAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hodor?", "Hodor!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _clientManagmentViewModel.CloseAccount();
                DialogResult = DialogResult.OK;
            }
        }

        private void dgvAccount_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _clientManagmentViewModel.Account.Id = (int)dgvAccount.Rows[0].Cells[0].Value;
            //_accountId = (int)dgvAccount.Rows[0].Cells[0].Value;
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            _clientManagmentViewModel.InsertRandomCard(_clientManagmentViewModel.Account.Id);

            dgvCards.DataSource = _clientManagmentViewModel.LoadCards(_clientManagmentViewModel.Account.Id);
            dgvCards.DataMember = "Card";
        }

        private void btnCloseCard_Click(object sender, EventArgs e)
        {
            _clientManagmentViewModel.UpdateCard(_clientManagmentViewModel.Account.Id, _clientManagmentViewModel.Card.Id);

            dgvCards.DataSource = _clientManagmentViewModel.LoadCards(_clientManagmentViewModel.Account.Id);
            dgvCards.DataMember = "Card";
        }

        private void dgvCards_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _clientManagmentViewModel.Card.Id = (int)dgvCards.Rows[e.RowIndex].Cells[0].Value;
            //_cardId = (int)dgvCards.Rows[e.RowIndex].Cells[0].Value;
            btnCloseCard.Enabled = true;
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvAccount.DataSource = _clientManagmentViewModel.LoadUpdatedClientManagment(_clientManagmentViewModel.Account.Id);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dgvAccount.DataSource = _clientManagmentViewModel.LoadUpdatedClientManagment(_clientManagmentViewModel.Account.Id);
        }
    }
}
