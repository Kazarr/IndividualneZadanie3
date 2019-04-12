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
        public AccountRepository AccountRepository { get; set; }
        public frmAccounts()
        {
            InitializeComponent();
            AccountRepository = new AccountRepository();
            dgvAccounts.DataSource = AccountRepository.LoadAccount();
            dgvAccounts.DataMember = "Account";
            dgvAccounts.Columns[0].Visible = false;
        }

        private void cmdManageAccount_Click(object sender, EventArgs e)
        {
            using (frmClientManagement newForm = new frmClientManagement())
            {
                newForm.ShowDialog();
            }
        }
    }
}
