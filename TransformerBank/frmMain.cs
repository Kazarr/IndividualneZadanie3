using Data.Models;
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
        private Card _card;
        private int COUNT = 0;
        public frmMain()
        {
            InitializeComponent();
            _mainViewModel = new MainViewModel();
            _card = new Card();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int cardId;

            if(int.TryParse(txtCardNumber.Text, out cardId))
            {
                _card.Id = cardId;
                if(_card.Id == cardId)
                {
                    if (_mainViewModel.CardExpireDate(cardId) > DateTime.Now)
                    {
                        if (COUNT < 3)
                        {
                            if (_mainViewModel.Login(cardId, txtPin.Text))
                            {
                                using (frmWithdrawal newform = new frmWithdrawal(cardId))
                                {
                                    newform.ShowDialog();
                                    if (newform.DialogResult == DialogResult.OK)
                                    {
                                        txtCardNumber.Text = null;
                                        txtPin.Text = null;
                                    }
                                }
                            }
                            else
                            {
                                COUNT++;
                            }
                        }
                        else
                        {
                            _mainViewModel.CloseCard(_card);
                        }
                    }
                }
                else
                {
                    COUNT = 0;
                }
            }
        }
    }
}
