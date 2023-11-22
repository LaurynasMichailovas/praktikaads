using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using Org.BouncyCastle.Tls;
namespace Mysqlconnect
{
    class sqlconn
    {
    MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=root;database=vikodb;");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
        public string getconnectionstring()
        { return "server=localhost;uid=root;pwd=root;database=vikodb;"; }
}   

}
