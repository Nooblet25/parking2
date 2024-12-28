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
using static DATAStruc.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DATAStruc
{
    public partial class CreateAcc : Form
    {
        public const string UserData = "UserData.json";

        public List<string> userName = new List<string>();
        public List<string> userPass = new List<string>();

        public CreateAcc()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public class Userinfo
        {
            public List<string> UserName { get; set; }
            public List<string> Password { get; set; }
        }
        private void Save_Data()
        {
            var info = new Userinfo
            {
                UserName = userName,
                Password = userPass
            };
            string json = JsonConvert.SerializeObject(info, Formatting.Indented);
            File.WriteAllText(UserData, json);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)//create username to
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

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string PassW = EnterPasstxtBx.Text;
            string ConfPassW = ConfirmPassTxtBx.Text;
            string Usern = textBox1.Text;
            if (string.IsNullOrWhiteSpace(Usern) || string.IsNullOrWhiteSpace(PassW) || string.IsNullOrWhiteSpace(ConfPassW))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }
            if (UsernameExists(Usern))
            {
                MessageBox.Show("This username already exists. Please choose a different username.");
                return;
            }
            if (PassW == ConfPassW)
            {
                userName.Add(Usern);
                userPass.Add(PassW);

                Save_Data(); 

                MessageBox.Show("Account created successfully!");
                textBox1.Clear();
                EnterPasstxtBx.Clear();
                ConfirmPassTxtBx.Clear();
            }
            else { MessageBox.Show("Password Do not match!!"); }
        }

    }
}
