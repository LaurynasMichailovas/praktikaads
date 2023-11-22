using Google.Protobuf.WellKnownTypes;
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

namespace Login
{
    public partial class Adminpage : Form
    {
        public Adminpage()
        {
            InitializeComponent();
            fillgrid();
            fillgrid2();
        }

        private void addstudent_Click(object sender, EventArgs e)
        {
            sqlconn a = new sqlconn();
            a.openConnection();
            try
            //INSERT INTO TableName (Column1, Column2, Column3) VALUES(Value1, Value2, Value3);
            {
                string querry = $"insert into student (user, password, name, lastname, gruope) values ('{student_username.Text}', ' {student_password.Text}', '{student_name.Text}', '{student_lastname.Text}', '{student_group.Text}')";
                MySqlCommand cmd = new MySqlCommand(querry, a.getConnection());

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("zeba");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { a.closeConnection(); }
        }

        private void student_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void add_teacher_Click(object sender, EventArgs e)
        {
            sqlconn a = new sqlconn();
            a.openConnection();
            try
            //INSERT INTO TableName (Column1, Column2, Column3) VALUES(Value1, Value2, Value3);
            {
                string querry = $"insert into teacher (user, password, name, lastname) values ('{teacher_username.Text}', ' {teacher_password.Text}', '{teacher_name.Text}', '{teacher_lastname.Text}')";
                MySqlCommand cmd = new MySqlCommand(querry, a.getConnection());

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("zeba");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { a.closeConnection(); }
        }
        private void fillgrid()
        {
            sqlconn a = new sqlconn();
            try
            {
                a.openConnection();
                string query = "SELECT * FROM vikodb.student;";
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
        private void fillgrid2()
        {
            sqlconn a = new sqlconn();
            try
            {
                a.openConnection();
                string query = "SELECT * FROM vikodb.teacher;";
                MySqlCommand cmd = new MySqlCommand(query, a.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView2.DataSource = table.DefaultView;
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void addsubject_Click(object sender, EventArgs e)
        {
            sqlconn a = new sqlconn();
            a.openConnection();
            try
            //INSERT INTO TableName (Column1, Column2, Column3) VALUES(Value1, Value2, Value3);
            {
                string querry = $"insert into subject (name) values ('{subject.Text}')";
                MySqlCommand cmd = new MySqlCommand(querry, a.getConnection());

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("zeba");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { a.closeConnection(); }
        }
    }
}
