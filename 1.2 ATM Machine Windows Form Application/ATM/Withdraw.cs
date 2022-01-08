using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BANK.Balance -= 500;
            MessageBox.Show("Your new balance is : " + BANK.Balance + " SAR ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BANK.Balance -= 1000;
            MessageBox.Show("Your new balance is : " + BANK.Balance + " SAR ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BANK.Balance -= 1500;
            MessageBox.Show("Your new balance is : " + BANK.Balance + " SAR ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BANK.Balance -= 2000;
            MessageBox.Show("Your new balance is : " + BANK.Balance + " SAR ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BANK.Balance -= 2500;
            MessageBox.Show("Your new balance is : " + BANK.Balance + " SAR ");
        }
    }
}
