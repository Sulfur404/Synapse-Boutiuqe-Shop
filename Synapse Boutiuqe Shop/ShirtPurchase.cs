using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synapse_Boutiuqe_Shop
{
    public partial class ShirtPurchase : Form
    {

        private String product = "Taaga Man Casual Fusion Shirt";
        private String proPrice = "320";
        private String quantity1 = "1";
        public ShirtPurchase()
        {
            InitializeComponent();
            counter[0] = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenCasual menCasual = new MenCasual();
            menCasual.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Interface01 interface01 = new Interface01();
            interface01.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = null;
            button1.BackgroundImage = Properties.Resources.shirtc1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = null;
            button1.BackgroundImage = Properties.Resources.shirtc2;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = null;
            button1.BackgroundImage = Properties.Resources.shirtc3;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Shipping shiping = new Shipping(product, proPrice, counter[0]);
            shiping.Show();
            this.Hide();
        }

        int[] counter = new int[1];

        private void button14_Click(object sender, EventArgs e)
        {
            counter[0]++;
            label16.Text = counter[0].ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (counter[0] > 0)
            {
                counter[0]--;
            }
            label16.Text = counter[0].ToString();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            label16.Text = counter[0].ToString();
        }
    }
}
