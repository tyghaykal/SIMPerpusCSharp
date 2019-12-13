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
    public partial class usrMgmtDerivedMember : UserControl
    {
        public usrMgmtDerivedMember()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            usrMgmtAdminLand admin = new usrMgmtAdminLand();
            this.Controls.Add(admin);
            admin.BringToFront();
            admin.Dock = DockStyle.Fill;
        }
    }
}
