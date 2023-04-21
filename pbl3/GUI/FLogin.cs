using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

       
        bool Login(string userName, string pw)
        {
            if (userName == "" && pw == "")
            {
                return false;
            }
            else return true;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string pw = txtPassword.Text;
            if (Login(userName, pw))
            {
                FUser f = new FUser();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản");
            }
            //
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            FRegister f = new FRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();
            //
        }

        private void FLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the program?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void NoShowPW1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                ShowPW1.BringToFront();
                txtPassword.PasswordChar = '*';
            }

        }
        private void ShowPW1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                NoShowPW1.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }
        //
    }
}
