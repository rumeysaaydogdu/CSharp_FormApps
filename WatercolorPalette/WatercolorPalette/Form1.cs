using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatercolorPalette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            listBox6.Items.Add(label10.Text+" "+label14.Text+" "+label15.Text+" "+ label16.Text + " " + label20.Text + " " + label19.Text + " " + label18.Text + " " + label17.Text + " " + label24.Text + " " + label23.Text + " " + label22.Text + " " + label21.Text);


            checkBox1.Checked = false;
            label10.Text = " ";


            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;

            label10.Text = " ";
            label14.Text = " ";
            label15.Text = " ";
            label16.Text = " ";
            label20.Text = " ";
            label19.Text = " ";
            label18.Text = " ";
            label17.Text = " ";
            label24.Text = " ";
            label23.Text = " ";
            label22.Text = " ";
            label21.Text = " ";


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = checkBox1.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label14.Text = checkBox2.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label15.Text = checkBox4.Text;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged_2(object sender, EventArgs e)
        {
            label16.Text = checkBox3.Text;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            label20.Text = checkBox8.Text;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            label19.Text = checkBox7.Text;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label18.Text = checkBox6.Text;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label17.Text = checkBox5.Text;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            label24.Text = checkBox12.Text;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            label23.Text = checkBox11.Text;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            label22.Text = checkBox10.Text;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            label21.Text = checkBox9.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            label10.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            label23.Text = "";
            label24.Text = "";
        }
    }
}
