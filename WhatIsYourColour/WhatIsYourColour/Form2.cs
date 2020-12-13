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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Black")
            {
                label4.Text = "Dear " + textBox1.Text + ", today is a hard day for you.";
                label4.Visible = true;

                button2.BackColor = Color.Black;
            }
            if (comboBox1.Text == "White")
            {
                label4.Text = "Dear " + textBox1.Text + ", today is a day full of surprises for you.";
                label4.Visible = true;

                button2.BackColor = Color.White;
            }
            if (comboBox1.Text == "Red")
            {
                label4.Text = "Dear " + textBox1.Text + ", there may be something to get excited about today.";
                label4.Visible = true;

                button2.BackColor = Color.Red;
            }
            if (comboBox1.Text == "Pink")
            {
                label4.Text = "Dear " + textBox1.Text + ", today you will have a good day.";
                label4.Visible = true;

                button2.BackColor = Color.Pink;
            }
            if (comboBox1.Text == "Purple")
            {
                label4.Text = "Dear " + textBox1.Text + ", a friend can text you today.";
                label4.Visible = true;

                button2.BackColor = Color.Purple;
            }
            if (comboBox1.Text == "Yellow")
            {
                label4.Text = "Dear " + textBox1.Text + ", you can get a gift today.";
                label4.Visible = true;

                button2.BackColor = Color.Yellow;
            }
            if (comboBox1.Text == "Orange")
            {
                label4.Text = "Dear " + textBox1.Text + ", you will eat a meal you love today.";
                label4.Visible = true;

                button2.BackColor = Color.Orange;
            }
            if (comboBox1.Text == "Blue")
            {
                label4.Text = "Dear " + textBox1.Text + ", you should look at the sky today!";
                label4.Visible = true;

                button2.BackColor = Color.Blue;
            }
            if (comboBox1.Text == "Green")
            {
                label4.Text = "Dear " + textBox1.Text + ", you should take a walk today.";
                label4.Visible = true;

                button2.BackColor = Color.Green;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

