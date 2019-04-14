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

namespace BankSystem
{
    public partial class frmTransaction : Form
    {
        private TransactionsViewModel _transactionsViewModel;
        private int _accountId;
        private bool _deposit;
        public frmTransaction()
        {
            InitializeComponent();
            _transactionsViewModel = new TransactionsViewModel();
            btnDone.Visible = true;
            btnOk.Visible = false;
        }

        public frmTransaction(int accountId, bool deposit)
        {
            _transactionsViewModel = new TransactionsViewModel();
            InitializeComponent();
            _accountId = accountId;
            _deposit = deposit;
            btnOk.Visible = true;
            btnDone.Visible = false;
            if (deposit)
            {
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


            }
            else
            {
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

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int amount;
            if (int.TryParse(txtAmount.Text, out amount) )
            {
                if (_deposit)
                {
                    _transactionsViewModel.Deposit(amount, _accountId);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    _transactionsViewModel.Withdrawal(amount, _accountId);
                    this.DialogResult = DialogResult.OK;
                }
                
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

        }
    }
}
