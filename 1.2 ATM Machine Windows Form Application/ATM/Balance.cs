using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Balance_Load(object sender, EventArgs e)
        {
            textBox1.Text += BANK.Balance + " SAR";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            MessageBox.Show("Thanks for Using ATM services…..Good By");
        }
    }
}
