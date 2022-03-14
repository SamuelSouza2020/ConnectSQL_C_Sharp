using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Desafio5
{
    public partial class Form1 : Form
    {
        
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;
        
        public Form1()
        {
            InitializeComponent();

            //Teste rápido pelo xampp sem necessidade de preencher, sem senha.
            /*server = "localhost";
            database = "connectcsharptomysql";
            user = "root";
            port = "3306";

            connectionString = String.Format("server={0};database={1};" +
                "Uid={2};port={3}", server, database, user,  port);
            connection = new MySqlConnection(connectionString);
            connection.Open();
            MessageBox.Show("successful connection");*/
        }

        private void conexion()
        {
            server = txtServer.Text;
            database = txtDatabase.Text;
            user = txtUser.Text;
            password = txtPassword.Text;
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                MessageBox.Show("successful connection");

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + connectionString);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            conexion();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}