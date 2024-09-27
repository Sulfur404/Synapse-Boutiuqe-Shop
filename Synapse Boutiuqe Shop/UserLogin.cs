using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synapse_Boutiuqe_Shop
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ForgotPassBtn_Click(object sender, EventArgs e)
        {

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userTextbox.Text) && !string.IsNullOrEmpty(passwordTextbox.Text))
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

                        string query = "  select * from [user information] where [User name]='" + userTextbox.Text + "' and Password='" + passwordTextbox.Text + "'";

                        SqlDataAdapter sda = new SqlDataAdapter(query, con);

                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            username = userTextbox.Text;
                            password = userTextbox.Text;


                            Interface01 interface01 = new Interface01();
                            interface01.Show();
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
                    catch (Exception ex)
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
    }
}
