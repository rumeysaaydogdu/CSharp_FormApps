using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matchScores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        int fbpuan = 0;
        int gspuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;

        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false; // bir kere tıklandıktan sonra tekrar tıklanamasın
            int a = rastgele.Next(0, 5); // 0 dahil 5 dahil değil
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label3.Text = a.ToString();
            label4.Text = b.ToString();
            label8.Text = c.ToString();
            label7.Text = d.ToString();

            if(Convert.ToInt32(label3.Text) == Convert.ToInt32(label4.Text))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labelgspuan.Text = gspuan.ToString();
            }
            else if (Convert.ToInt32(label3.Text) > Convert.ToInt32(label4.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            else
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(label8.Text) == Convert.ToInt32(label7.Text))
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            else if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label7.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            else
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false; // bir kere tıklandıktan sonra tekrar tıklanamasın
            int a = rastgele.Next(0, 5); // 0 dahil 5 dahil değil
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label18.Text = a.ToString();
            label17.Text = b.ToString();
            label13.Text = c.ToString();
            label12.Text = d.ToString();

            if (Convert.ToInt32(label18.Text) == Convert.ToInt32(label17.Text))
            {
                gspuan = gspuan + 1;
                bjkpuan = bjkpuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labelgspuan.Text = gspuan.ToString();
            }
            else if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label17.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            else
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }

            if (Convert.ToInt32(label13.Text) == Convert.ToInt32(label12.Text))
            {
                fbpuan = fbpuan + 1;
                tspuan = tspuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }
            else if (Convert.ToInt32(label13.Text) > Convert.ToInt32(label12.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            else
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false; // bir kere tıklandıktan sonra tekrar tıklanamasın
            int a = rastgele.Next(0, 5); // 0 dahil 5 dahil değil
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label28.Text = a.ToString();
            label27.Text = b.ToString();
            label23.Text = c.ToString();
            label22.Text = d.ToString();

            if (Convert.ToInt32(label28.Text) == Convert.ToInt32(label27.Text))
            {
                fbpuan = fbpuan + 1;
                bjkpuan = bjkpuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }
            else if (Convert.ToInt32(label28.Text) > Convert.ToInt32(label27.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            else
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }

            if (Convert.ToInt32(label23.Text) == Convert.ToInt32(label22.Text))
            {
                gspuan = gspuan + 1;
                tspuan = tspuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelgspuan.Text = gspuan.ToString();
            }
            else if (Convert.ToInt32(label23.Text) > Convert.ToInt32(label22.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            else
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labeltspuan.Text))
            {
                button5.BackColor = Color.DarkBlue;
                button6.BackColor = Color.Yellow;
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\fb.jpg";
                label42.Text = "The champion is Fenerbahçe!";

                button5.Visible = true;
                button6.Visible = true;
                pictureBox1.Visible = true;
                label42.Visible = true;
            }

            if (Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labeltspuan.Text))
            {
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Yellow;
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\gs.jpg";
                label42.Text = "The champion is Galatasaray!";

                button5.Visible = true;
                button6.Visible = true;
                pictureBox1.Visible = true;
                label42.Visible = true;
            }

            if (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text))
            {
                button5.BackColor = Color.Black;
                button6.BackColor = Color.White;
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\bjk.jpg";
                label42.Text = "The champion is Beşiktaş!";

                button5.Visible = true;
                button6.Visible = true;
                pictureBox1.Visible = true;
                label42.Visible = true;
            }

            if (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelgspuan.Text))
            {
                button5.BackColor = Color.DarkRed;
                button6.BackColor = Color.Blue;
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\ts.jpg";
                label42.Text = "The champion is Tranzonspor!";

                button5.Visible = true;
                button6.Visible = true;
                pictureBox1.Visible = true;
                label42.Visible = true;
            }

        }
    }
}
