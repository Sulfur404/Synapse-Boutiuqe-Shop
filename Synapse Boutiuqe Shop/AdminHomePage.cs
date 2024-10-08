﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synapse_Boutiuqe_Shop
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserInformation userInformation = new UserInformation();
            userInformation.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserInformation userInformation = new UserInformation();
            userInformation.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contribute contribute = new Contribute();
            contribute.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Contribute contribute = new Contribute();
            contribute.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddAdmin addAdmin = new AddAdmin();
            addAdmin.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddAdmin addAdmin = new AddAdmin();
            addAdmin.Show();
            this.Hide();
        }
    }
}
