using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Synapse_Boutiuqe_Shop
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            LoginForm.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conntionstring = "Data Source=MOSTAFI-NAFIS\\SQLEXPRESS;Initial Catalog=\"Synapse Boutiuqe Shop\";Integrated Security=True;Trust Server Certificate=True;";
            SqlConnection con = new SqlConnection(conntionstring);
            con.Open();

            string name = firstname.Text + lastname.Text;
            string user = username.Text;
            string pass = password.Text;
            string dateof = date.Text;
            string Email = email.Text;
            string question = comboBox1.Text;
            string qanswer = answer.Text;


            string query = "INSERT INTO [User Information] (Name, [User Name], Password, [Date Of Birth], Email, [Security Question], [User Question Answer]) VALUES ('" + name + "', '" + user + "', '" + pass + "', '" + dateof + "', '" + Email + "', '" + question + "', '" + qanswer + "')";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("All Data Insert");
        }
    }
}
