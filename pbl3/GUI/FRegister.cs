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
    public partial class FRegister : Form
    {
        public FRegister()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            //guna2Panel1.BackColor = Color.FromArgb(200, 0, 0, 0);
        }

       

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btRegistration_Click_1(object sender, EventArgs e)
        {
            if (tbFullname.Text == "" || tbUsername.Text == "" || tbPassword.Text == "" || tbEmail.Text == "" || tbPhone.Text == "" || tbRePassword.Text == "")
            {
                MessageBox.Show(" Nhập đầy đủ thông tin cần thiết để đăng ký!");
            }
            else
            {
                if (tbPassword.Text != tbRePassword.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận không đúng!");
                }
                else
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!");
                    this.Dispose();
                }
            }
        }

        private void NoShowPW1_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '\0' && tbRePassword.PasswordChar == '\0')
            {
                ShowPW1.BringToFront();
                ShowPW2.BringToFront();
                tbPassword.PasswordChar = '*';
                tbRePassword.PasswordChar = '*';
            }
        }

        private void ShowPW1_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '*' && tbRePassword.PasswordChar == '*')
            {
                NoShowPW1.BringToFront();
                NoShowPW2.BringToFront();
                tbPassword.PasswordChar = '\0';
                tbRePassword.PasswordChar = '\0';
            }
        }

        private void NoShowPW2_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '\0' && tbRePassword.PasswordChar == '\0')
            {
                ShowPW1.BringToFront();
                ShowPW2.BringToFront();
                tbPassword.PasswordChar = '*';
                tbRePassword.PasswordChar = '*';
            }
        }

        private void ShowPW2_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '*' && tbRePassword.PasswordChar == '*')
            {
                NoShowPW1.BringToFront();
                NoShowPW2.BringToFront();
                tbPassword.PasswordChar = '\0';
                tbRePassword.PasswordChar = '\0';
            }
        }
    }
}
