using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DATAStruc.Form1;
using static DATAStruc.CreateAcc;

namespace DATAStruc
{
    public partial class Login : Form
    {
        private Form1 mainform;
        public Login(Form1 form)
        {
            InitializeComponent();
            mainform = form;
        }

        private void UserNameTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTxtBx_TextChanged(object sender, EventArgs e)
        {

        } 

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private Userinfo LoadData()
        {
            if (File.Exists(UserData))
            {
                string json = File.ReadAllText(UserData);
                return JsonConvert.DeserializeObject<Userinfo>(json);
            }
            else
            {
                return new Userinfo
                {
                    UserName = new List<string>(),
                    Password = new List<string>()
                };
            }
        }
        private bool UsernameExists(string username)
        {
            Userinfo data = LoadData();

            return data.UserName != null && data.UserName.Contains(username, StringComparer.OrdinalIgnoreCase);
        }
        private bool PasswordExists(string password)
        {
            Userinfo data = LoadData();

            return data.Password != null && data.Password.Contains(password, StringComparer.OrdinalIgnoreCase);
        }
        private void EnterBtn_Click(object sender, EventArgs e)
        {

            string TextBxUN = UserNameTxtBx.Text;
            string TextBxPW = PasswordTxtBx.Text;
            if (string.IsNullOrWhiteSpace(TextBxUN) || string.IsNullOrWhiteSpace(TextBxPW))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }
            if (UsernameExists(TextBxUN) && PasswordExists(TextBxPW))
            {
                this.Close();

            }
            else { MessageBox.Show("Login failed!!"); }
        }

        private void CreateAccLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAcc CreateAcc = new CreateAcc();
            this.Hide();
            CreateAcc.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Hide();
        }
    }
}
