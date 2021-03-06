﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Repositories;

namespace BankSystem
{
    public partial class frmAccounts : Form
    {
        private AccountsViewModel _accountsViewModel;
        //private string _idNumber;
        public frmAccounts()
        {
            InitializeComponent();
            _accountsViewModel = new AccountsViewModel();
            dgvAccounts.DataSource = _accountsViewModel.LoadAccounts(txtFilterAccountNumber.Text, txtFilterAccountFirstName.Text, txtFilterAccountLastName.Text);
            dgvAccounts.DataMember = "Account";
            dgvAccounts.Columns[0].Visible = false;
            _accountsViewModel.IdNumber = (string)dgvAccounts.Rows[0].Cells["IdNumber"].Value;
        }

        private void cmdManageAccount_Click(object sender, EventArgs e)
        {
            using (frmClientManagement newForm = new frmClientManagement(_accountsViewModel.IdNumber))
            {
                newForm.ShowDialog();
            }
        }

        private void dgvAccounts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _accountsViewModel.IdNumber = (string)dgvAccounts.Rows[e.RowIndex].Cells["IdNumber"].Value;
        }

        private void txtFilterAccountNumber_TextChanged(object sender, EventArgs e)
        {
            dgvAccounts.DataSource = _accountsViewModel.LoadAccounts(txtFilterAccountNumber.Text, txtFilterAccountFirstName.Text, txtFilterAccountLastName.Text);
            dgvAccounts.DataMember = "Account";
            dgvAccounts.Columns[0].Visible = false;
        }

        private void txtFilterAccountFirstName_TextChanged(object sender, EventArgs e)
        {
            dgvAccounts.DataSource = _accountsViewModel.LoadAccounts(txtFilterAccountNumber.Text, txtFilterAccountFirstName.Text, txtFilterAccountLastName.Text);
            dgvAccounts.DataMember = "Account";
            dgvAccounts.Columns[0].Visible = false;
        }

        private void txtFilterAccountLastName_TextChanged(object sender, EventArgs e)
        {
            dgvAccounts.DataSource = _accountsViewModel.LoadAccounts(txtFilterAccountNumber.Text, txtFilterAccountFirstName.Text, txtFilterAccountLastName.Text);
            dgvAccounts.DataMember = "Account";
            dgvAccounts.Columns[0].Visible = false;
        }
    }
}
