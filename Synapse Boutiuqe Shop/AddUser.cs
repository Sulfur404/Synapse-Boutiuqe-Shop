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
            Random random = new Random();
            int num = random.Next(6,8);
            int total = 0; 
            string captcha = "";
            do
            {
                int chr = random.Next(48, 123);
                if((chr >= 48 && chr <= 57) || (chr >=65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha += (char)chr;
                    total++;
                    if(total == num)
                        break;
                    {

                    }
        
                }
            } while (true);
            lbcaptcha.Text = captcha;

        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(firstname.Text) &&
                !string.IsNullOrEmpty(lastname.Text) &&
                !string.IsNullOrEmpty(date.Text) &&
                !string.IsNullOrEmpty(comboBox1.Text) &&
                !string.IsNullOrEmpty(comboBox2.Text) &&
                !string.IsNullOrEmpty(radioButton1.Text) &&
                !string.IsNullOrEmpty(username.Text) &&
                !string.IsNullOrEmpty(password.Text) &&
                !string.IsNullOrEmpty(answer.Text) &&
                !string.IsNullOrEmpty(captcha.Text) &&
                !string.IsNullOrEmpty(email.Text))
            {
                
                if (lbcaptcha.Text != captcha.Text)
                {
                    MessageBox.Show("Captcha is Incorrect! Please try again", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                
                string connectionString = "Data Source=MOSTAFI-NAFIS\\SQLEXPRESS;Initial Catalog=\"Synapse Boutiuqe Shop\";Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();

                        string query = "INSERT INTO [User Information] (Name, [User Name], Password, [Date Of Birth], Email, [Security Question], [User Question Answer]) " +
                                       "VALUES (@name, @user, @pass, @dateof, @Email, @question, @qanswer)";

                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@name", firstname.Text + " " + lastname.Text); // Added space between first and last name
                        cmd.Parameters.AddWithValue("@user", username.Text);
                        cmd.Parameters.AddWithValue("@pass", password.Text);
                        cmd.Parameters.AddWithValue("@dateof", date.Text);
                        cmd.Parameters.AddWithValue("@Email", email.Text);
                        cmd.Parameters.AddWithValue("@question", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@qanswer", answer.Text);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DialogResult result = MessageBox.Show("Are you sure you want to insert all information?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    AdminHomePage adminHomePage = new AdminHomePage();
                    adminHomePage.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please fill up all required information.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
