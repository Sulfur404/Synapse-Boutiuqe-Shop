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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            LoginForm.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void adduseerBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username.Text) &&
                !string.IsNullOrEmpty(comboBox2.Text) &&
                !string.IsNullOrEmpty(answer.Text) &&
                !string.IsNullOrEmpty(email.Text))
            {
                
                string username1 = username.Text;
                string question = comboBox2.Text;
                string answer1 = answer.Text;
                string email1 = email.Text;

                string connectionString = "Data Source=MOSTAFI-NAFIS\\SQLEXPRESS;Initial Catalog=\"Synapse Boutiuqe Shop\";Integrated Security=True;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();

                        
                        string query = "SELECT * FROM [User Information] WHERE [User Name]=@UserName AND [Security Question]=@SecurityQuestion AND [User Question Answer]=@Answer AND [Email]=@Email";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@UserName", username1);
                        cmd.Parameters.AddWithValue("@SecurityQuestion", question);
                        cmd.Parameters.AddWithValue("@Answer", answer1);
                        cmd.Parameters.AddWithValue("@Email", email1);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        
                        if (dt.Rows.Count > 0)
                        {
                            RecoveryCode recoveryCode = new RecoveryCode(username1,email1);
                            recoveryCode.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid details. Try Again!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            username.Clear();
                            answer.Clear();
                            email.Clear();
                            username.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
