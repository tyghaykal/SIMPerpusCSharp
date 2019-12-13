using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Flurl.Http;
using System.Collections.Specialized;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        private static readonly HttpClient client = new HttpClient();
        String usernameInput, passwordInput;
        //user information
        String userLogin, username, userPrivilege, userGender, joinDate;
        int userAge;
        public frmLogin()
        {
            InitializeComponent();           
        }

        private void tbUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbPasswd_OnValueChanged(object sender, EventArgs e)
        {
            passwordInput = tbPasswd.Text;
            tbPasswd.isPassword = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                values["usernameL"] = usernameInput;
                values["passwordL"] = passwordInput;

                var response = client.UploadValues("http://teyege08.000webhostapp.com/tygLogin.php", values);
                var rsp = Encoding.Default.GetString(response);
                JObject jsonObject = JObject.Parse(rsp);

                bool benar = Convert.ToBoolean(jsonObject["success"]);
                MessageBox.Show(rsp + "");
                if (benar) {
                    
                    userLogin = jsonObject["namaUser"] + "";
                    username = jsonObject["username"] + "";
                    userPrivilege = jsonObject["privilege"] + "";
                    userAge = Convert.ToInt32(jsonObject["umur"]);
                    userGender = jsonObject["gender"] + "";
                    joinDate = jsonObject["joinDate"] + "";
                    frmMain Main = new frmMain(userLogin, username, userPrivilege, userGender, joinDate, userAge);
                    Main.Show();

                }
                else
                {
                    MessageBox.Show("Password Salah!" + Environment.NewLine + "Jancuk", "ERRORRR TONGKLO!!!!");
                }
            }

        }

        private void صورة_دائرة1_Click(object sender, EventArgs e)
        {
            

        }

        private void tbUsername_OnValueChanged_1(object sender, EventArgs e)
        {
            usernameInput = tbUsername.Text;
        }
    }
}
