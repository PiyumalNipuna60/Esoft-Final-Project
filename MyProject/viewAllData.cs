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
    public partial class viewAllData : Form
    {
        public viewAllData()
        {
            InitializeComponent();
            MessageBox.Show("ok");
            tableLoad();
        }

        private void tableLoad()
        {
            MessageBox.Show("ok2");
            string connectionString = "server=localhost;database=my_project;uid=root;password=1234;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {

                connection.Open();
                string query = "SELECT regNo, first_name, last_name, dateOfBirth, gender, address, email, mobilePhone, homePhone FROM student";
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
