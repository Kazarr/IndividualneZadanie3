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
    public partial class frmAccount : Form
    {
        private AccountViewModel _accountViewModel;
        /// <summary>
        /// Used when adding new account.
        /// </summary>
        public frmAccount()
        {
            InitializeComponent();
            btnOk.Visible = false;
            btnSave.Visible = true;
        }

        /// <summary>
        /// Used when viewing/updating existing account.
        /// </summary>
        /// <param name="clientId"></param>
        public frmAccount(int accountId)
        {
            InitializeComponent();
            btnOk.Visible = true;
            btnSave.Visible = false;
            _accountViewModel = new AccountViewModel(accountId);
            lblIBAN.Text = _accountViewModel.GetAccountIBA();
            lblAmount.Text = _accountViewModel.GetAccountAmount().ToString();
            lblAcutalOverFlowValue.Text = _accountViewModel.GetAccountActualOverFlow().ToString();
            txtOverFlowLimit.Text = _accountViewModel.GetAccountOverFlowLimit().ToString();
            dtpCreationDate.Value = _accountViewModel.GetAccountCreatioDate();
            txtFirstName.Text = _accountViewModel.GetClientFirstName();
            txtLastName.Text = _accountViewModel.GetClientLastName();
            txtAdress.Text = _accountViewModel.GetClientAdress();
            txtCity.Text = _accountViewModel.GetCityName();
            txtPostalCode.Text = _accountViewModel.GetCityPostalCode();
            txtIdNumber.Text = _accountViewModel.GetClientIdNumber();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            decimal overFlowLimit;
            if(decimal.TryParse(txtOverFlowLimit.Text,out overFlowLimit))
            {
                _accountViewModel.SetAccountOverFlowLimit(overFlowLimit);
            }
            _accountViewModel.SetClientFirstName(txtFirstName.Text);
            _accountViewModel.SetClientlastName(txtLastName.Text);
            _accountViewModel.SetClientAdress(txtAdress.Text);
            _accountViewModel.SetCityName(txtCity.Text);
            _accountViewModel.SetCityPostaCode(txtPostalCode.Text);
            _accountViewModel.SetClientIdNumber(txtIdNumber.Text);



            _accountViewModel.UpdateAccountOverFlowLimit();
            _accountViewModel.UpdateClient();
            _accountViewModel.UpdateCity();

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
