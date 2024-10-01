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
    public partial class WomenTraditionInterface : Form
    {
        public WomenTraditionInterface()
        {
            InitializeComponent();
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
            Interface01 interface01 = new Interface01();
            interface01.Show();
            this.Hide();
        }

        private void WomenTraditionInterface_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Interface01 interface01 = new Interface01();
            interface01.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KimonoPurshase kimonoPurshase = new KimonoPurshase();
            kimonoPurshase.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            KimonoPurshase kimonoPurshase = new KimonoPurshase();
            kimonoPurshase.Show();
            this.Hide();
        }
    }
}
