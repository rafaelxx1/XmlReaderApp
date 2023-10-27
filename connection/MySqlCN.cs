using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace XmlReaderApp.connection
{
    internal class MySqlCN
    {
        private string _connectionString;
        private MySqlConnection _connection;
        
        public MySqlConnection OpenConnection()
        {
             _connectionString = $"Server=localhost;Port=3306;Database=XmlReader;User=root;Password=root;";
             _connection = new MySqlConnection(_connectionString);

            try
            {
                if(_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open();
                    Console.WriteLine("ABERTA");
                }
            }catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return _connection;
        }

        public void CloseConnection()
        {
            if(_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
                Console.WriteLine("fechada");
            }
        }
        
    }
}
