using MySql.Data.MySqlClient;
using XmlReaderApp.connection;
using XmlReaderApp.model;

namespace XmlReaderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb1.Text = "Account";
            lb2.Text = "Password";


        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string account = account_txt.Text;
            string password = password_txt.Text;

            MessageBox.Show("YOUR ACCOUNT IS: " + account + "YOUR PASSWORD IS: " + password);
        }


        private void link_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.ShowDialog();
        }
    }
}