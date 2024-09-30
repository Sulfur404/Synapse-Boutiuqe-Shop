using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synapse_Boutiuqe_Shop
{
    public partial class Shipping : Form
    {
        private string name;
        private string price;
        private int quantity;
        public Shipping(string name, string price, int quantity)
        {
            InitializeComponent();
            this.name = name;
            this.price = price;
            this.quantity = quantity;

            
        }

        private void Shipping_Load(object sender, EventArgs e)
        {
            label28.Text = name;
            label29.Text = "$"+ price;
            label30.Text = quantity.ToString();
            label31.Text = "$" + price + " X " + quantity.ToString();

            float priceValue;
            if (float.TryParse(price, out priceValue))
            {
                float vat = (priceValue * quantity) * 0.05f;
                label33.Text = $"{vat}" + "(5%)";

                float subValue;
                if (float.TryParse(price, out subValue))
                {
                    float sub = (subValue * quantity) + vat;
                    label34.Text = "$" + $"{sub}";
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface01 interface01 = new Interface01();
            interface01.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {
            
        }
    }
}
