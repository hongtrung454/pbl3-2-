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
    public partial class FTableManager : Form
    {
        public FTableManager()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(250, 28, 53, 46);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTK());
        }
    }
}
