﻿using System;
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
    public partial class frmMain : Form
    {
        public MainViewModel MainViewModel { get; set; }
        public frmMain()
        {
            InitializeComponent();
            MainViewModel = new MainViewModel();
            dgvTop10MaxMoney.DataSource = MainViewModel.GetMaxMoneyClients();
            dgvTop10MaxMoney.DataMember = "Account";
            dgvTop10MaxMoney.Columns[0].Visible = false;
            dgvTop10MaxMoney.Columns[1].Visible = false;
            dgvTop10MaxMoney.Columns[2].Visible = false;
            dgvTop10MaxMoney.Columns[4].Visible = false;
            dgvBankMoney.DataSource = MainViewModel.GetBankMoney();
            dgvBankMoney.DataMember = "Account";
            dgvCount.DataSource = MainViewModel.GetAccountCount();
            dgvCount.DataMember = "Account";
        }

        private void cmdFindClient_Click(object sender, EventArgs e)
        {
            
            if (MainViewModel.FindClient(txtFindClient.Text))
            {
                lblError.Visible = false;
                using (frmClientManagement newForm = new frmClientManagement(txtFindClient.Text))
                {
                    newForm.ShowDialog();
                }
            }
            else
            {
                lblError.Text = "Ty kokot taky tam neni";
                lblError.Visible = true;
            }
        }

        private void cmdNewAccount_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllAccounts_Click(object sender, EventArgs e)
        {
            using (frmAccounts newForm = new frmAccounts())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions())
            {
                newForm.ShowDialog();
            }
        }
    }
}
