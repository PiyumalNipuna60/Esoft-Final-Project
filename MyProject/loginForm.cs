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
            if (userName.Text == "lashadi" && password.Text == "1234")
            {
                homePage homePage = new homePage();
                homePage.Show();
                this.Hide();
            }
            else if (userName.Text != "lashadi" && password.Text != "1234")
            {
                MessageBox.Show("Invalied user name and password..!", "Invalied login details.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userName.Clear();
                password.Clear();
            }
            else if (userName.Text != "lashadi")
            {
                MessageBox.Show("Invalied user name and password..!", "Invalied login details.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userName.Clear();
                password.Clear();
            }
            else if (password.Text != "1234")
            {
                MessageBox.Show("Invalied user name and password..!", "Invalied login details.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userName.Clear();
                password.Clear();
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
    }
}
