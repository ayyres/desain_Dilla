using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desain_Dilla
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           peminjamanBuku1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardAdmin1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            masterBukuk1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            masterSiswa1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pengembalianBuku1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 formBaru = new Form1();
            formBaru.Show();
        }
    }
}
