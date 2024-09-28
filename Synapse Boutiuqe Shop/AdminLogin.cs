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
using System.Data.SqlClient;

namespace Synapse_Boutiuqe_Shop
{

    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Opacity = 0.8;  // Makes the form semi-transparent
            this.BackColor = Color.FromArgb(0, 255, 255, 255); // Set the background color
            this.TransparencyKey = this.BackColor;
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(userTextbox.Text) && !string.IsNullOrEmpty(passwordTextbox.Text))
            {
                String username;
                String password;

                username = userTextbox.Text;
                password = passwordTextbox.Text;

                string connectionString = "Data Source=MOSTAFI-NAFIS\\SQLEXPRESS;Initial Catalog=\"Synapse Boutiuqe Shop\";Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();

                        string query = "  select * from admin where Username='"+userTextbox.Text+"' and Password='"+passwordTextbox.Text+"'";

                        SqlDataAdapter sda = new SqlDataAdapter(query, con);

                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if(dt.Rows.Count > 0)
                        {
                            username = userTextbox.Text;
                            password = userTextbox.Text;


                            AdminHomePage homePage = new AdminHomePage();
                            homePage.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid login details.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            userTextbox.Clear();
                            passwordTextbox.Clear();
                            userTextbox.Focus();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill up all required information.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
