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
    public partial class VestPurshase : Form
    {

        private String productBlazer = "The Koo les Stri ed Suit Vest";
        private String proPrice = "810";
        public VestPurshase()
        {
            InitializeComponent();
            counter[0] = 1;
        }

        private void button12_Click(object sender, EventArgs e)
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
            InterfaceFormal interfaceFormal = new InterfaceFormal();
            interfaceFormal.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = null;
            button1.BackgroundImage = Properties.Resources.vest1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = null;
            button1.BackgroundImage = Properties.Resources.vest3;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = null;
            button1.BackgroundImage = Properties.Resources.vest2;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Shipping shipping = new Shipping(productBlazer, proPrice, counter[0]);
            shipping.Show();
            this.Hide();
        }

        int[] counter = new int[1];

        private void label16_Click(object sender, EventArgs e)
        {

        }

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

        private void VestPurshase_Load(object sender, EventArgs e)
        {
            label16.Text = counter[0].ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Interface01 interface01 = new Interface01();
            interface01.Show();
            this.Hide();
        }
    }
}
