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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            LoginForm.BackColor = Color.FromArgb(100, 0, 0, 0);

            Random random = new Random();
            int num = random.Next(6, 8);
            int total = 0;
            string captcha = "";
            do
            {
                int chr = random.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha += (char)chr;
                    total++;
                    if (total == num)
                        break;
                    {

                    }

                }
            } while (true);
            bcaptcha.Text = captcha;
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void adduseerBtn_Click(object sender, EventArgs e)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
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

                if (bcaptcha.Text != captcha.Text)
                {
                    MessageBox.Show("Captcha is Incorrect! Please try again", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(email.Text, emailPattern))
                {
                    MessageBox.Show("Invalid Email Address! Please enter a valid email.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                        cmd.Parameters.AddWithValue("@name", firstname.Text + " " + lastname.Text);
                        cmd.Parameters.AddWithValue("@user", username.Text);
                        cmd.Parameters.AddWithValue("@pass", password.Text);
                        cmd.Parameters.AddWithValue("@dateof", date.Text);
                        cmd.Parameters.AddWithValue("@Email", email.Text);
                        cmd.Parameters.AddWithValue("@question", comboBox2.Text);
                        cmd.Parameters.AddWithValue("@qanswer", answer.Text);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DialogResult result = MessageBox.Show("Are you sure to Sign Up?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    UserLogin userLogin = new UserLogin();
                    userLogin.Show();
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
