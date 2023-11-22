using Login.Properties;
using MySql.Data.MySqlClient;
using Mysqlconnect;
using System.Data;
using System.Text;
namespace Login
{
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void passwordtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void adminp_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void teacherp_TextChanged(object sender, EventArgs e)
        {

        }

        private void teacher_TextChanged(object sender, EventArgs e)
        {

        }

        private void student_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            sqlconn a = new sqlconn();
            a.openConnection();
            string studentusername, studentpassword;
            studentusername = student_user.Text;
            studentpassword = student_password.Text;
            try
            {
                string querry = "select * from vikodb.student where user = '" + student_user.Text + "' and password = '" + student_password.Text + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(querry, new MySqlConnection("server=localhost;uid=root;pwd=root;database=vikodb;"));
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    studentusername = student_user.Text;
                    studentpassword = student_password.Text;
                    User user = new User();
                    user.setlogin(studentusername);
                    MessageBox.Show("Login success");
                    userpage f4 = new userpage(user);
                    f4.Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { a.closeConnection(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlconn a = new sqlconn();
                a.openConnection();

                MySqlCommand cmd = new MySqlCommand("select * from vikodb.teacher", a.getConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show((string)reader["user"], (string)reader["password"]);
                }
                a.closeConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("nepavyko");
            }
        }

        private void login2_Click(object sender, EventArgs e)
        {
            sqlconn a = new sqlconn();
            a.openConnection();
            string teacherusername, teacherpassword;
            teacherusername = teacher_user.Text;
            teacherpassword = teacher_password.Text;
            try
            {
                string querry = "select * from vikodb.teacher where user = '" + teacher_user.Text + "' and password = '" + teacher_password.Text + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(querry, new MySqlConnection("server=localhost;uid=root;pwd=root;database=vikodb;"));
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    teacherusername = teacher_user.Text;
                    teacherpassword = teacher_password.Text;

                    MessageBox.Show("Login success");
                    teacherpage f3 = new teacherpage();
                    f3.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
            finally { a.closeConnection(); }



        }

        private void login3_Click(object sender, EventArgs e)
        {
            sqlconn a = new sqlconn();
            a.openConnection();
            string adminusername, adminpassword;
            adminusername = admin_user.Text;
            adminpassword = admin_password.Text;
            try
            {
                string querry = "select * from admin where user = '" + admin_user.Text + "' and password = '" + admin_password.Text + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(querry, new MySqlConnection("server=localhost;uid=root;pwd=root;database=vikodb;"));
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    adminusername = admin_user.Text;
                    adminpassword = admin_password.Text;

                    MessageBox.Show("Login success");
                    Adminpage f2 = new Adminpage();
                    f2.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
            finally { a.closeConnection(); }
        }

              private string connectionString = "server=localhost;uid=root;pwd=root;database=vikodb;";
        

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userbox.Text;
            string password = passwordbox.Text;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to check user credentials
                    string query = "SELECT * FROM student WHERE user = @username AND password = @password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                // Successful login
                                MessageBox.Show("Login successful!");
                                // You can open a new form, set visibility to true, etc.
                            }
                            else 
                            {
                                Exception ex;
                                MessageBox.Show("Invalid username or password");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
