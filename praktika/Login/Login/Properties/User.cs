using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace Login.Properties
{
    public class User
    {   

        public string username;
        public string password;
        public void setlogin(string username)
        { this.username = username; }
        public string getlogin() { 
        return this.username;
        }
    }
}
