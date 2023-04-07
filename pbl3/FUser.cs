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
    public partial class FUser : Form
    {
        public FUser()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            openChildForm(new cfSearch());
        }
        private void btnTuVan_Click(object sender, EventArgs e)
        {
            openChildForm(new cfTV());
        }

        private void btnMyTree_Click(object sender, EventArgs e)
        {
            openChildForm(new cfMyTree());
        }

        private void btnPIC_Click(object sender, EventArgs e)
        {
            openChildForm(new cfPIC());

        }

        
    }
}
