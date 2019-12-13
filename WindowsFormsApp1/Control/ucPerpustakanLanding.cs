using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ucPerpustakanLanding : UserControl
    {
        public ucPerpustakanLanding()
        {
            InitializeComponent();
        }

        private void btnKblBuku_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            //tbIDBuku.Text = tbIDMember.Text = string.Empty;
        }

        private void tbIDBuku_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbIDMember_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tbIDPeminjaman_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnReset1_Click_1(object sender, EventArgs e)
        {
            tbIDPeminjaman.Text = string.Empty;
        }

        private void btnReset2_Click_1(object sender, EventArgs e)
        {
            tbIDMember.Text = tbIDBuku.Text = string.Empty;
        }
    }
}
