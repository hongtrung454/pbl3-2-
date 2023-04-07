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

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin tài khoản");
            }
            else
            {
                FUser f = new FUser();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void Formc_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if(MessageBox .Show("Do you really want to exit the program?", "Thông Báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            //guna2Panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btSignIn_Click(object sender, EventArgs e)
        {

            
            FRegister f = new FRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();
             
                
        }

        private void ShowPW2_Click(object sender, EventArgs e)
        {

        }

        private void NoShowPW3_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '\0')
            {
                ShowPW3.BringToFront();           
                tbPassword.PasswordChar = '*';           
            }
        }

        private void ShowPW3_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '*')
            {
                NoShowPW3.BringToFront();
                tbPassword.PasswordChar = '\0';
            }
        }

       
    }
}
