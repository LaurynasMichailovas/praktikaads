using Login.Properties;
using MySql.Data.MySqlClient;
using Mysqlconnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class userpage : Form
    {


        public User User = new User();
        public userpage(User user)
        {
            InitializeComponent();
            User = user;
            fillgrid();


        }
        private void fillgrid()
        {
            string username = User.getlogin();
            sqlconn a = new sqlconn();
            try
            {
                a.openConnection();
                string query = $"SELECT  st.name as \"first name \", st.lastname as \"last name\", s.name, g.grade\r\nFROM grades as g\r\nJOIN subject s ON g.subject_idsubject = s.idsubject\r\nJOIN student st ON g.student_idstudent = st.idstudent\r\n where st.user='{username}';";
                MySqlCommand cmd = new MySqlCommand(query, a.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                a.closeConnection();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
