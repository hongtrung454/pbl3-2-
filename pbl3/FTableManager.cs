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
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {
            guna2Panel3.BackColor = Color.FromArgb(250, 28, 53, 46);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
