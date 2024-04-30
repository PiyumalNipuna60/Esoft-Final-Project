using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (CheckUserNameAndPassword(userName.Text, password.Text))
            {
                homePage homePage = new homePage();
                homePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalied user name and password..!", "Invalied login details.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userName.Clear();
                password.Clear();
            }
        }

        private bool CheckUserNameAndPassword(String userName, String password)
        {
            string connectionString = "server=localhost;database=my_project;uid=root;password=1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM login WHERE user_name=@userName AND password=@password";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    } 
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    MessageBox.Show("An error occurred. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userName.Clear();
            password.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            signInForm signInForm = new signInForm();
            signInForm.Show();
            this.Hide();
        }
    }
}