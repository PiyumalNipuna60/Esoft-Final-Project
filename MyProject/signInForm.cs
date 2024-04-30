using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MyProject
{
    public partial class signInForm : Form
    {
        public signInForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=my_project;uid=root;password=1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO login(address, contact, user_name, password) values(@address,@contact,@userName,@password)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@address", txtAddress.Text);
                    command.Parameters.AddWithValue("@contact", txtContactNo.Text);
                    command.Parameters.AddWithValue("@userName", txtUserName.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record added successfully.", "Registration User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Record not added.", "Registration User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    MessageBox.Show("An error occurred. Please try again.", "Registration User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearData()
        {
            txtAddress.Clear();
            txtContactNo.Clear();
            txtPassword.Clear();
            txtUserName.Clear();
        }
    }
}
