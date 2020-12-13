using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatIsYourColour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "123")
            {
                Form2 gecis = new Form2();
                gecis.Show();
                this.Hide();
            }
            else if(textBox1.Text != "admin" && textBox2.Text == "123")
            {
                MessageBox.Show("Wrong username. Try again.");
                textBox1.Clear();
                textBox2.Clear();
            }
            else if (textBox1.Text == "admin" && textBox2.Text != "123")
            {
                MessageBox.Show("Wrong password. Try again.");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Wrong username and password. Try again.");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
