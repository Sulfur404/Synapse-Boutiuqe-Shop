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
    public partial class Blazerpurchase : Form
    {
        public Blazerpurchase()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InterfaceFormal interfaceFormal = new InterfaceFormal();
            interfaceFormal.Show();
            this.Hide();
        }

        private void optionBtn_Click(object sender, EventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Shipping shipping = new Shipping();
            shipping.Show();
            this.Hide();
        }
    }
}
