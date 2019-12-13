using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        string userLogin, username, userPrivilege, userGender, joinDate;
        int userAge;

        public frmMain(string _userLogin, string _username, string _userPrivilege, string _userGender, string _joinDate, int _userAge)
        {
            InitializeComponent();
            userLogin = _userLogin;
            username = _username;
            userPrivilege = _userPrivilege;
            userGender = _userGender;
            joinDate = _joinDate;
            userAge = _userAge;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbCariBuku_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            if(ucBooks.Visible == false)
            {
                ucBooks.Visible = true;
                ucHome1.Visible = false;
                ucPerpustakanLanding1.Visible = false;
                usrMgmtAdminLand1.Visible = false;
                usrMgmtStaffLand1.Visible = false;
                btnBuku.Iconimage_right = Properties.Resources.balek;
                btnMgmntUser.Iconimage_right = btnPerpustakaan.Iconimage_right = Properties.Resources.icons8_Forward_Arrow_24px;
                

            }
            else
            {
                ucBooks.Visible = false;
                ucHome1.Visible = true;
                usrMgmtAdminLand1.Visible = false;
                usrMgmtStaffLand1.Visible = false;
                btnBuku.Iconimage_right = Properties.Resources.icons8_Forward_Arrow_24px;
            }
            

        }

        private void frmMain_Load(object sender, EventArgs e)
        { 
            ucPerpustakanLanding1.Visible = false;
            usrMgmtAdminLand1.Visible = false;
            usrMgmtStaffLand1.Visible = false;
            ucBooks.Visible = false;
            ucHome1.Visible = true;
            lblUserLogin.Text = userLogin;
            lblUserPrivelege.Text = "Login sebagai : " + userPrivilege;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPerpustakaan_Click(object sender, EventArgs e)
        {
            if (ucPerpustakanLanding1.Visible == false)
            {
                ucBooks.Visible = false;
                ucHome1.Visible = false;
                ucPerpustakanLanding1.Visible = true;
                usrMgmtAdminLand1.Visible = false;
                usrMgmtStaffLand1.Visible = false;
                btnPerpustakaan.Iconimage_right = Properties.Resources.balek;
                btnMgmntUser.Iconimage_right = btnBuku.Iconimage_right = Properties.Resources.icons8_Forward_Arrow_24px;
                
            }
            else
            {
                ucBooks.Visible = false;
                ucHome1.Visible = true;
                ucPerpustakanLanding1.Visible = false;
                usrMgmtAdminLand1.Visible = false;
                usrMgmtStaffLand1.Visible = false;
                btnPerpustakaan.Iconimage_right = Properties.Resources.icons8_Forward_Arrow_24px;
            }
            
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {            
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                btnMaximize.Iconimage = Properties.Resources.icons8_Up_Right_24px;
                
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                btnMaximize.Iconimage = Properties.Resources.icons8_Down_Left_24px_3;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(panelLeft.Width == 332)
            {
                btnMenuSlider.Location = new Point(12, 9);
                panelLeft.Visible = false;
                panelLeft.Width = 50;
                anmSlider.HideSync(panelLeft);
                anmSlider.Interval = 5;
                anmSlider.ShowSync(panelLeft);
                

                
            }
            else
            {
                btnMenuSlider.Location = new Point(299, 6);
                panelLeft.Visible = false;
                panelLeft.Width = 332;
                anmSlider.Interval = 5;
                anmSlider.ShowSync(panelLeft);
            }
        }

        private void btnMgmntUser_Click(object sender, EventArgs e)
        {
            
            
            if(userPrivilege == "admin")
            {
                if (usrMgmtAdminLand1.Visible == false)
                {
                    ucBooks.Visible = false;
                    ucHome1.Visible = false;
                    ucPerpustakanLanding1.Visible = false;
                    usrMgmtAdminLand1.Visible = true;
                    usrMgmtStaffLand1.Visible = false;
                    btnMgmntUser.Iconimage_right = Properties.Resources.balek;
                    btnBuku.Iconimage_right =btnPerpustakaan.Iconimage_right = Properties.Resources.icons8_Forward_Arrow_24px;
                    
                }
                else
                {
                    ucBooks.Visible = false; 
                    ucHome1.Visible = true;
                    ucPerpustakanLanding1.Visible = false;
                    usrMgmtAdminLand1.Visible = false;
                    usrMgmtStaffLand1.Visible = false;
                    btnMgmntUser.Iconimage_right = Properties.Resources.icons8_Forward_Arrow_24px;
                }
                
            }
            else
            {
                if (usrMgmtStaffLand1.Visible == false)
                {
                    ucBooks.Visible = false;
                    ucHome1.Visible = false;
                    ucPerpustakanLanding1.Visible = false;
                    usrMgmtAdminLand1.Visible = false;
                    usrMgmtStaffLand1.Visible = true;
                    btnMgmntUser.Iconimage_right = Properties.Resources.balek;
                    btnBuku.Iconimage_right = btnPerpustakaan.Iconimage_right = Properties.Resources.icons8_Forward_Arrow_24px;
                    
                }
                else
                {
                    ucBooks.Visible = false;
                    ucHome1.Visible = true;
                    ucPerpustakanLanding1.Visible = false;
                    usrMgmtAdminLand1.Visible = false;
                    usrMgmtStaffLand1.Visible = false;
                    btnMgmntUser.Iconimage_right = Properties.Resources.icons8_Forward_Arrow_24px;
                }
            }
            
        }

        private void usrMgmtStaffLand1_Load(object sender, EventArgs e)
        {
            
        }

        private void lblUserLogin_Click(object sender, EventArgs e)
        {

        }

        private void usrMgmtAdminLand1_Load(object sender, EventArgs e)
        {
            

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void panelAtas_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
