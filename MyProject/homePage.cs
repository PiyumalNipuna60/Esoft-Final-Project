using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MyProject
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void homePage_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=my_project;uid=root;password=1234;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "SELECT regNo FROM student";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    cmbRegNo.Items.Add(mySqlDataReader.GetString(0));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ragistration Student.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedItem = cmbRegNo.SelectedItem.ToString();
            if (selectedItem != null)
            {
                searchStudent(selectedItem);
            }
        }

        private void searchStudent(String selectedItem)
        {
            string connectionString = "server=localhost;database=my_project;uid=root;password=1234;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "SELECT * FROM student WHERE regNo=@regNo";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@regNo", selectedItem);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtFistName.Text = reader.GetString(1);
                    txtLastName.Text = reader.GetString(2);
                    dateTimePicker.Text = reader.GetString(3);

                    if (reader.GetString(4) == "male")
                    {
                        radioButton1.Select();
                    }
                    else
                    {
                        radioButton2.Select();
                    }

                    txtAddress.Text = reader.GetString(5);
                    txtEmail.Text = reader.GetString(6);
                    txtMobileNo.Text = reader.GetString(7);
                    txtHomeNo.Text = reader.GetString(8);
                    txtParentName.Text = reader.GetString(9);
                    txtNic.Text = reader.GetString(10);
                    txtParentContact.Text = reader.GetString(11);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ragistration Student.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connection.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void clearData()
        {
            cmbRegNo.Text = "";
            txtFistName.Clear();
            txtLastName.Clear();
            dateTimePicker.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobileNo.Clear();
            txtHomeNo.Clear();
            txtParentName.Clear();
            txtNic.Clear();
            txtParentContact.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String fistName = txtFistName.Text;
            String lastName = txtLastName.Text;
            String birthDay = dateTimePicker.Text;
            String gender = "male";
            if (radioButton1.Checked)
            {
                gender = "male";
            }
            else if (radioButton2.Checked)
            {
                gender = "female";
            }

            String address = txtAddress.Text;
            String email = txtEmail.Text;
            String mobileNo = txtMobileNo.Text;
            String homeNo = txtHomeNo.Text;
            String perantName = txtParentName.Text;
            String nic = txtNic.Text;
            String perantContact = txtParentContact.Text;

            string connectionString = "server=localhost;database=my_project;uid=root;password=1234;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "INSERT INTO student(first_name,last_name,dateOfBirth,gender,address,email,mobilePhone," +
                    "homePhone,parentName,nic,contactNo) VALUES(@fistName, @lastName, @birthDay, @gender, @address, @email, @mobileNo, @homeNo, @perantName, @nic, @perantContact)";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@fistName", fistName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@birthDay", birthDay);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@mobileNo", mobileNo);
                command.Parameters.AddWithValue("@homeNo", homeNo);
                command.Parameters.AddWithValue("@perantName", perantName);
                command.Parameters.AddWithValue("@nic", nic);
                command.Parameters.AddWithValue("@perantContact", perantContact);

                int reader = command.ExecuteNonQuery();

                if (reader > 0)
                {
                    MessageBox.Show("Record added successfully..!", "Ragistration Student.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();

                }
                else
                {
                    MessageBox.Show("Somthing Wrong..!", "Ragistration Student.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ragistration Student.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedItem = cmbRegNo.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedItem))
            {
                MessageBox.Show("Please select a registration number.", "Registration Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost;database=my_project;uid=root;password=1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM student WHERE regNo=@regNo";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@regNo", selectedItem);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.", "Registration Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records found for deletion.", "Registration Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    MessageBox.Show("An error occurred. Please try again.", "Registration Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedItem == null)
            {
                MessageBox.Show("Please select a registration number.", "Registration Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string firstName = txtFistName.Text;
            string lastName = txtLastName.Text;
            string birthDay = dateTimePicker.Text;
            string gender = radioButton1.Checked ? "male" : "female";
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            string mobileNo = txtMobileNo.Text;
            string homeNo = txtHomeNo.Text;
            string parentName = txtParentName.Text;
            string nic = txtNic.Text;
            string parentContact = txtParentContact.Text;

            string connectionString = "server=localhost;database=my_project;uid=root;password=1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE student SET first_name=@first_name, last_name=@last_name, dateOfBirth=@birthDay, gender=@gender, address=@address, email=@email, mobilePhone=@mobileNo, homePhone=@homeNo, parentName=@parentName, nic=@nic, contactNo=@parentContact WHERE regNo=@regNo";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@first_name", firstName);
                    command.Parameters.AddWithValue("@last_name", lastName);
                    command.Parameters.AddWithValue("@birthDay", birthDay);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@mobileNo", mobileNo);
                    command.Parameters.AddWithValue("@homeNo", homeNo);
                    command.Parameters.AddWithValue("@parentName", parentName);
                    command.Parameters.AddWithValue("@nic", nic);
                    command.Parameters.AddWithValue("@parentContact", parentContact);
                    command.Parameters.AddWithValue("@regNo", cmbRegNo.SelectedItem.ToString());

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully!", "Registration Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearData(); // Assuming this function correctly clears the form data.
                    }
                    else
                    {
                        MessageBox.Show("No records updated.", "Registration Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Registration Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Log the exception for debugging purposes
                }
            }
        }

    }
}
