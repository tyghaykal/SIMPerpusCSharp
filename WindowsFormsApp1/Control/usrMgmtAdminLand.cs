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
    public partial class usrMgmtAdminLand : UserControl
    {
        usrMgmtDerivedMember member = new usrMgmtDerivedMember();
        usrMgmtDerivedStaff staff = new usrMgmtDerivedStaff();
            
        public usrMgmtAdminLand()
        {
            InitializeComponent();
        }

        private void btnMgmtMember_Click(object sender, EventArgs e)
        {
            usrMgmtAdminLand member = new usrMgmtAdminLand();
            this.Controls.Add(member);
            member.BringToFront();
        }

        private void btnMgmtMember_Click_1(object sender, EventArgs e)
        {
            this.Controls.Add(member);
            member.Show();
            member.Visible = true;
            member.BringToFront();
            member.Dock = DockStyle.Fill;
        }

        private void btnMgmtStaff_Click(object sender, EventArgs e)
        {
            this.Controls.Add(staff);
            staff.Show();
            staff.Visible = true;
            staff.BringToFront();
            staff.Dock = DockStyle.Fill;
        }

        private void btnMenuSlider_Click(object sender, EventArgs e)
        {
            this.Controls.Add(member);
            this.Controls.Add(staff);
            member.SendToBack();
            staff.SendToBack();
        }
    }
}
