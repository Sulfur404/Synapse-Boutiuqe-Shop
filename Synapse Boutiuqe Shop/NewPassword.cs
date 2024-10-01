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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Synapse_Boutiuqe_Shop
{
    public partial class NewPassword : Form
    {
        string username;
        public NewPassword(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewPassword_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void adduseerBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pass.Text) && !string.IsNullOrEmpty(newpass.Text) && pass.Text == newpass.Text)
            {
                string connectionString = "Data Source=MOSTAFI-NAFIS\\SQLEXPRESS;Initial Catalog=\"Synapse Boutiuqe Shop\";Integrated Security=True;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();

                        string query = "UPDATE [User Information] SET [Password] = @password WHERE [User Name] = @username";

                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@password", newpass.Text);
                        cmd.Parameters.AddWithValue("@username", username);  

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    UserLogin userLogin = new UserLogin();
                    userLogin.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match or are empty.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
