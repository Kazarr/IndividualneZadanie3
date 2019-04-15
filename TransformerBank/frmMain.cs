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
    public partial class frmMain : Form
    {
        private MainViewModel _mainViewModel;
        public frmMain()
        {
            InitializeComponent();
            _mainViewModel = new MainViewModel();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            int cardId;
            if(int.TryParse(txtCardNumber.Text, out cardId))
            {
                if(_mainViewModel.Login(cardId, txtPin.Text))
                {
                    using (frmWithdrawal newform = new frmWithdrawal(cardId))
                    {
                        newform.ShowDialog();
                    }
                }
            }
            
        }
    }
}
