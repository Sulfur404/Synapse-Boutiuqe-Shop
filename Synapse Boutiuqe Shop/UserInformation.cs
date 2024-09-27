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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Synapse_Boutiuqe_Shop
{
    public partial class UserInformation : Form
    {
        public UserInformation()
        {
            InitializeComponent();
        }

        private void UserInformation_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string userNameToDelete = dataGridView1.SelectedRows[0].Cells["User Name"].Value.ToString();

            string connectionString = "Data Source=MOSTAFI-NAFIS\\SQLEXPRESS;Initial Catalog=\"Synapse Boutiuqe Shop\";Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string deleteQuery = "DELETE FROM [Synapse Boutiuqe Shop].[dbo].[User Information] WHERE [User Name] = @UserName";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                    deleteCmd.Parameters.AddWithValue("@UserName", userNameToDelete);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string fetchQuery = "SELECT TOP (1000) [Name],[User Name],[Password],[Date Of Birth],[Email],[Security Question],[User Question Answer] FROM [Synapse Boutiuqe Shop].[dbo].[User Information]";
                    SqlCommand fetchCmd = new SqlCommand(fetchQuery, con);

                    SqlDataReader reader = fetchCmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void showbtn1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MOSTAFI-NAFIS\\SQLEXPRESS;Initial Catalog=\"Synapse Boutiuqe Shop\";Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT TOP (1000) [Name],[User Name],[Password],[Date Of Birth],[Email],[Security Question],[User Question Answer] FROM [Synapse Boutiuqe Shop].[dbo].[User Information]";
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dataGridView1.DataSource = dt;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    dataGridView1.ReadOnly = true;

                    dataGridView1.AllowUserToAddRows = false;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void showbtn2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MOSTAFI-NAFIS\\SQLEXPRESS;Initial Catalog=\"Synapse Boutiuqe Shop\";Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT TOP (1000) [Name],[User Name],[Password],[Date Of Birth],[Email],[Security Question],[User Question Answer] FROM [Synapse Boutiuqe Shop].[dbo].[User Information]";
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dataGridView1.DataSource = dt;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    dataGridView1.ReadOnly = true;

                    dataGridView1.AllowUserToAddRows = false;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void deletebtn2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string userNameToDelete = dataGridView1.SelectedRows[0].Cells["User Name"].Value.ToString();

            string connectionString = "Data Source=MOSTAFI-NAFIS\\SQLEXPRESS;Initial Catalog=\"Synapse Boutiuqe Shop\";Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string deleteQuery = "DELETE FROM [Synapse Boutiuqe Shop].[dbo].[User Information] WHERE [User Name] = @UserName";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                    deleteCmd.Parameters.AddWithValue("@UserName", userNameToDelete);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string fetchQuery = "SELECT TOP (1000) [Name],[User Name],[Password],[Date Of Birth],[Email],[Security Question],[User Question Answer] FROM [Synapse Boutiuqe Shop].[dbo].[User Information]";
                    SqlCommand fetchCmd = new SqlCommand(fetchQuery, con);

                    SqlDataReader reader = fetchCmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void updatebtn1_Click(object sender, EventArgs e)
        {
            Update upate = new Update();
            upate.Show();
            this.Close();
        }

        private void updatebtn2_Click(object sender, EventArgs e)
        {
            Update upate = new Update();
            upate.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
