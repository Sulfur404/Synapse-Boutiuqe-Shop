using System;
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
    public partial class Interface01 : Form
    {
        public Interface01()
        {
            InitializeComponent();
        }

        private void Interface01_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenCasual interfaceCasual = new MenCasual();
            interfaceCasual.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InterfaceFormal interfaceFormal = new InterfaceFormal();
            interfaceFormal.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WomenInterfaceFormal womenInterfaceFormal = new WomenInterfaceFormal();
            womenInterfaceFormal.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MenCasual interfaceCasual = new MenCasual();
            interfaceCasual.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            InterfaceFormal interfaceFormal = new InterfaceFormal();
            interfaceFormal.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            WomenInterfaceFormal womenInterfaceFormal = new WomenInterfaceFormal();
            womenInterfaceFormal.Show();
            this.Hide();
        }
    }
}
