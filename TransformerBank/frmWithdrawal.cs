using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformerBank
{
    public partial class frmWithdrawal : Form
    {
        private WithdrawalViewModel _withdrawalViewModel;
        public frmWithdrawal(int cardId)
        {
            InitializeComponent();
            _withdrawalViewModel = new WithdrawalViewModel(cardId);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            _withdrawalViewModel.Withdraw5();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            _withdrawalViewModel.Withdraw10();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            _withdrawalViewModel.Withdraw20();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            _withdrawalViewModel.Withdraw50();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            _withdrawalViewModel.Withdraw100();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            _withdrawalViewModel.Withdraw200();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            _withdrawalViewModel.Withdraw500();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
