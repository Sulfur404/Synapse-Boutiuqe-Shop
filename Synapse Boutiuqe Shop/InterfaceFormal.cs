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
    public partial class InterfaceFormal : Form
    {
        public InterfaceFormal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Interface01 interface01 = new Interface01();
            interface01.Show();
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

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Blazerpurchase blazerpurchase = new Blazerpurchase();
            blazerpurchase.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Interface01 interface01 = new Interface01();
            interface01.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VestPurshase vestPurshase = new VestPurshase();
            vestPurshase.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            VestPurshase vestPurshase = new VestPurshase();
            vestPurshase.Show();
            this.Hide();
        }
    }
}
