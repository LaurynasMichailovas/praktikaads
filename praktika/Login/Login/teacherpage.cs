using MySql.Data.MySqlClient;
using Mysqlconnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class teacherpage : Form
    {
        public teacherpage()
        {
            InitializeComponent();
            fillgrid();
            FillComboBox();
            FillComboBox2();
            FillComboBox3();
            FillComboBox4();
        }
        private void FillComboBox()
        {
            sqlconn a = new sqlconn();
            a.openConnection();
            try
            {
                {


                    string query = "SELECT gruope FROM student";

                    using (MySqlCommand command = new MySqlCommand(query, a.getConnection()))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["gruope"].ToString());
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { a.closeConnection(); }
        }
        private void FillComboBox2()
        {
            sqlconn a = new sqlconn();
            a.openConnection();
            try
            {
                {
                    string query = "SELECT name, lastname FROM student";
                    using (MySqlCommand command = new MySqlCommand(query, a.getConnection()))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string fullname = $"{reader["name"]} {reader["lastname"]}";
                            comboBox2.Items.Add(fullname);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { a.closeConnection(); }
        }
        private void FillComboBox3()
        {
            sqlconn a = new sqlconn();
            a.openConnection();
            try
            {
                {


                    string query = "SELECT name FROM subject";

                    using (MySqlCommand command = new MySqlCommand(query, a.getConnection()))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            comboBox3.Items.Add(reader["name"].ToString());
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { a.closeConnection(); }
        }
        private void FillComboBox4()
        {
            for (int i = 1; i <= 10; i++)
            {
                comboBox4.Items.Add(i);
            }
        }
        private void fillgrid()
        {
            sqlconn a = new sqlconn();
            try
            {
                a.openConnection();
                string query = "SELECT * FROM student;";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = "";
            string lastname = "";
            int grade = 0;
            string subject = "";
            sqlconn a = new sqlconn();

            if (comboBox2.SelectedItem != null)
            {
                string selectedItem = comboBox2.SelectedItem.ToString();


                string[] parts = selectedItem.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 2)
                {

                    firstname = parts[0];
                    lastname = parts[1];

                }

            }
            if (comboBox3.SelectedItem != null && comboBox1.SelectedItem != null)
            {
                subject = comboBox3.SelectedItem.ToString();
            }
            if (comboBox4.SelectedItem != null)
            {
                grade = (int)comboBox4.SelectedItem;
            }
            try
            {
                a.openConnection();


                string query = $"iNSERT INTO Grades (grade, subject_idsubject, student_idstudent)\r\nVALUES ( '{grade}', \r\n    (SELECT idsubject FROM subject WHERE name = '{subject}'),\r\n    (SELECT idstudent FROM student WHERE user = (select user from student where name ='{firstname}' and lastName='{lastname}'))\r\n);";
                MessageBox.Show(grade.ToString());
                MessageBox.Show(subject);
                MessageBox.Show(firstname);
                MessageBox.Show(lastname);
                MySqlCommand cmd = new MySqlCommand(query, a.getConnection());
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("sekmingai");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { a.closeConnection(); }
        }

        private void logoff_Click(object sender, EventArgs e, Loginpage loginpage)
        {
            this.Close();
        }

        private void logoff_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
