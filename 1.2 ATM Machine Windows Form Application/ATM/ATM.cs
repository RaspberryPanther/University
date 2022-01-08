using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit d1 = new Deposit();
            d1.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw w1 = new Withdraw();
            w1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Balance b1 = new Balance();
            b1.Show();
        }

        private void qutbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            MessageBox.Show("Thanks for Using ATM services…..Good By");
        }
    }
}
