using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public partial class BANK : Form
    {
        public static int Balance = 20000;
        public BANK()
        {
            InitializeComponent();
            textPin.PasswordChar = '*';

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user, pass;
            user = textUser.Text;
            pass = textPin.Text;

            if (user =="admin" && pass=="1234")
            {
                MessageBox.Show("Welcome! \n you have logged in successfully");
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
            }
            else
            {

                MessageBox.Show("User Name or Password is Wrong!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textUser.Clear();
            textPin.Clear();
        }

        private void textPin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
