using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace playDice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int totalYou = 0;
        int totalComputer = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            int a = rnd.Next(1, 7);
            int b = rnd.Next(1, 7);

            label3.Text = a.ToString();
            label4.Text = b.ToString();

            label6.Text = (a + b).ToString();

            totalYou = totalYou + a + b;

            label16.Text = totalYou.ToString();

            if(a == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\1.jpg";
            }
            else if(a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\2.jpg";
            }
            else if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\3.jpg";
            }
            else if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\4.jpg";
            }
            else if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\5.jpg";
            }
            else if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\6.png";
            }


            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\DELL\\Desktop\\1.jpg";
            }
            else if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\DELL\\Desktop\\2.jpg";
            }
            else if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\DELL\\Desktop\\3.jpg";
            }
            else if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\DELL\\Desktop\\4.jpg";
            }
            else if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\DELL\\Desktop\\5.jpg";
            }
            else if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\DELL\\Desktop\\6.png";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;

            int c = rnd.Next(1, 7);
            int d = rnd.Next(1, 7);

            label10.Text = c.ToString();
            label9.Text = d.ToString();

            label7.Text = (c + d).ToString();

            totalComputer = totalComputer + c + d;

            label15.Text = totalComputer.ToString();


            if (c == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\1.jpg";
            }
            else if (c == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\2.jpg";
            }
            else if (c == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\3.jpg";
            }
            else if (c == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\4.jpg";
            }
            else if (c == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\5.jpg";
            }
            else if (c == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\6.png";
            }


            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\DELL\\Desktop\\1.jpg";
            }
            else if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\DELL\\Desktop\\2.jpg";
            }
            else if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\DELL\\Desktop\\3.jpg";
            }
            else if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\DELL\\Desktop\\4.jpg";
            }
            else if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\DELL\\Desktop\\5.jpg";
            }
            else if(d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\DELL\\Desktop\\6.png";
            }


            if (totalYou >= 100 && totalYou > totalComputer)
            {
                label14.Text = "Congrats, you won!!";
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else if (totalComputer >= 100 && totalComputer > totalYou)  // else if yapmazsak ilk 100 olan değil son hamleden sonra computer da 100 ü geçerse otomaatik olarak onu kazanmış sayıyıor
            {
                label14.Text = "Sorry, the computer won. :(";
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }
    }
}
