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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Synapse_Boutiuqe_Shop
{
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(password.Text))
            {
                string connectionString = "Data Source=MOSTAFI-NAFIS\\SQLEXPRESS;Initial Catalog=\"Synapse Boutiuqe Shop\";Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();

                        string query = "INSERT INTO Admin (UserName, Password) " + "VALUES (@user, @pass)";
                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@user", username.Text);
                        cmd.Parameters.AddWithValue("@pass", password.Text);

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
