using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Synapse_Boutiuqe_Shop
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UserInformation userInformation = new UserInformation();
            userInformation.Show();
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

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            LoginForm.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void adduseerBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username.Text))
            {
                
                string connectionString = "Data Source=MOSTAFI-NAFIS\\SQLEXPRESS;Initial Catalog=\"Synapse Boutiuqe Shop\";Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();

                        string query = "UPDATE [User Information] SET ";
                        bool isFirst = true;

                        if (!string.IsNullOrEmpty(firstname.Text) || !string.IsNullOrEmpty(lastname.Text))
                        {
                            query += "Name = @name";
                            isFirst = false;
                        }
                        if (!string.IsNullOrEmpty(date.Text))
                        {
                            query += (isFirst ? "" : ", ") + "[Date Of Birth] = @dateof";
                            isFirst = false;
                        }
                        if (!string.IsNullOrEmpty(email.Text))
                        {
                            query += (isFirst ? "" : ", ") + "Email = @Email";
                            isFirst = false;
                        }
                        if (!string.IsNullOrEmpty(comboBox2.Text))
                        {
                            query += (isFirst ? "" : ", ") + "[Security Question] = @question";
                            isFirst = false;
                        }
                        if (!string.IsNullOrEmpty(answer.Text))
                        {
                            query += (isFirst ? "" : ", ") + "[User Question Answer] = @qanswer";
                        }

                        query += " WHERE [User Name] = @userId";

                        SqlCommand cmd = new SqlCommand(query, con);

                        if (!string.IsNullOrEmpty(firstname.Text) || !string.IsNullOrEmpty(lastname.Text))
                        {
                            cmd.Parameters.AddWithValue("@name", firstname.Text + " " + lastname.Text);
                        }
                        if (!string.IsNullOrEmpty(date.Text))
                        {
                            cmd.Parameters.AddWithValue("@dateof", date.Text);
                        }
                        if (!string.IsNullOrEmpty(email.Text))
                        {
                            cmd.Parameters.AddWithValue("@Email", email.Text);
                        }
                        if (!string.IsNullOrEmpty(comboBox2.Text))
                        {
                            cmd.Parameters.AddWithValue("@question", comboBox2.Text);
                        }
                        if (!string.IsNullOrEmpty(answer.Text))
                        {
                            cmd.Parameters.AddWithValue("@qanswer", answer.Text);
                        }

                        cmd.Parameters.AddWithValue("@userId", username.Text);

                        if (query.Contains("SET "))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("User information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No fields were updated as no input was provided.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        con.Close();
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
                MessageBox.Show("Please Provide User Name.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
