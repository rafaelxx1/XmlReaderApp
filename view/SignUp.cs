using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlReaderApp.connection;

namespace XmlReaderApp.model
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            lb_name.Text = "Nome: ";
            lb_email.Text = "E-mail: ";
            lb_password.Text = "Password: ";
            btn_register.Text = "Create";
        }

        private void btn_register_Click(object sender, EventArgs e)
        {


            if (txb_name.Text == "")
            {
                lb_info.Text = "Name can't be null";
                lb_info.ForeColor = Color.Red;
                lb_info.Show();
            }
            if(txb_email.Text == "")
            {
                lb_info.Text = "E-mail can't be null";
                lb_info.ForeColor = Color.Red;
                lb_info.Show();
            }
            if(txb_password.Text == "")
            {
                lb_info.Text = "Password can't be null";
                lb_info.ForeColor = Color.Red;
                lb_info.Show();
            }else
            {
                lb_info.Hide();
                string name = txb_name.Text;
                string email = txb_email.Text;
                string password = txb_password.Text;

                string queryInsert = "INSERT INTO tb_user(user_name, user_email, user_password) VALUES(@UserName, @UserEmail, @UserPassword)";
                MySqlCN mysql = new MySqlCN();

                MySqlCommand cmd = new MySqlCommand(queryInsert, mysql.OpenConnection());
                cmd.Parameters.AddWithValue("@UserName", name);
                cmd.Parameters.AddWithValue("@UserEmail", email);
                cmd.Parameters.AddWithValue("@UserPassword", password);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Inserção bem-sucedida!");
                }
                else
                {
                    MessageBox.Show("Nenhuma linha foi inserida.");
                }
            }

        }
    }
}
