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

            MySqlCN mysql = new MySqlCN();
            if (IsConnected(mysql)) // Verifique se a conexão foi bem-sucedida
            {
                MessageBox.Show("Conectado !");

                /***string query = "INSERT INTO tb_user(user_name, user_email, user_password) VALUES('RAFAEL', 'rafaelsantosfr@hotmail.com','123123')";

                MySqlCommand cmd = new MySqlCommand(query, mysql.OpenConnection());
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Inserção bem-sucedida!");
                }
                else
                {
                    MessageBox.Show("Nenhuma linha foi inserida.");
                }***/



            }
            else
            {
                // A conexão falhou. Trate esse cenário adequadamente.
                MessageBox.Show("Não foi possível estabelecer a conexão com o banco de dados.");
            }



            bool IsConnected(MySqlCN mysql)
            {
                try
                {
                    mysql.OpenConnection();
                    return true;
                }
                catch (Exception ex)
                {
                    // Trate exceções relacionadas à conexão aqui.
                    MessageBox.Show("Erro ao tentar conectar ao banco de dados: " + ex.Message);
                    return false;
                }
            }
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