using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;
using Data.Repositories;

namespace BankSystem
{
    public partial class frmTransaction : Form
    {
        private TransactionsViewModel _transactionsViewModel;
        //private int _destinationAccountId;
        private bool _deposit;
        public frmTransaction(Account account)
        {
            InitializeComponent();
            _transactionsViewModel = new TransactionsViewModel(account);
            _transactionsViewModel.Account = account;
            btnDone.Visible = true;
            btnOk.Visible = false;
            lblIbanSend.Text = account.IBAN;
        }

        public frmTransaction(Account account, bool deposit)
        {
            _transactionsViewModel = new TransactionsViewModel(account);
            _transactionsViewModel.Account = account;
            InitializeComponent();
            _deposit = deposit;
            btnOk.Visible = true;
            btnDone.Visible = false;
            if (deposit)
            {
                #region Visibility
                lblIbanSend.Visible = false;
                lblFirstNameSend.Visible = false;
                lblLastNameSend.Visible = false;

                lblVariableMark.Visible = false;
                txtVS.Visible = false;
                lblSpecificMark.Visible = false;
                txtSS.Visible = false;
                lblConstantMark.Visible = false;
                txtKS.Visible = false;
                txtMessage.Visible = false;

                lblAmount.Visible = true;
                txtAmount.Visible = true;

                lblIbanRecieved.Visible = true;
                txtIban.Visible = true;
                lblFirstNameRecieved.Visible = true;
                lblLastNameRecieved.Visible = true;
                #endregion
                txtIban.Text = account.IBAN;
                txtIban.Enabled = false;
                lblFirstNameRecieved.Text = _transactionsViewModel.Client.FirstName;
                lblLastNameRecieved.Text = _transactionsViewModel.Client.LastName;
            }
            else
            {
                #region Visibility
                lblIbanSend.Visible = true;
                lblFirstNameSend.Visible = true;
                lblLastNameSend.Visible = true;
                lblAmount.Visible = true;
                txtAmount.Visible = true;

                lblVariableMark.Visible = false;
                txtVS.Visible = false;
                lblSpecificMark.Visible = false;
                txtSS.Visible = false;
                lblConstantMark.Visible = false;
                txtKS.Visible = false;
                txtMessage.Visible = false;

                lblIbanRecieved.Visible = false;
                txtIban.Visible = false;
                lblFirstNameRecieved.Visible = false;
                lblLastNameRecieved.Visible = false;
                #endregion
                lblIbanSend.Text = account.IBAN;
                lblFirstNameSend.Text = _transactionsViewModel.Client.FirstName;
                lblLastNameSend.Text = _transactionsViewModel.Client.LastName;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int amount;
            if (int.TryParse(txtAmount.Text, out amount) )
            {
                if (_deposit)
                {
                    _transactionsViewModel.Deposit(amount,_transactionsViewModel.Account.Id);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    _transactionsViewModel.Withdrawal(amount, _transactionsViewModel.Account.Id);
                    this.DialogResult = DialogResult.OK;
                }
                
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            int amount;
            if(int.TryParse(txtAmount.Text, out amount))
            {
                _transactionsViewModel.InsertTransaction(amount, _transactionsViewModel.Account.Id, _transactionsViewModel.FindAccountByIban(txtIban.Text));
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
