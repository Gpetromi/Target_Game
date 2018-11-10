using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frog_game
{
    public partial class Form3 : Form
    {

        int hits;
        int counter = 30;
        Random random = new Random();
        public Form3()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(new Bitmap("dart.png"), 100, 100);
            this.Cursor = new Cursor(bmp.GetHicon());
            button2.Cursor = Cursors.Default;
            button1.Cursor = Cursors.Default;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hits++;
            label1.Text = hits.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            label4.Text = counter.ToString();
            if (counter == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                pictureBox1.Enabled = false;

                string today = DateTime.Now.ToString("dd-MM-yyyy");
                string now = DateTime.Now.ToString(("HH:mm:ss"));

                StreamWriter w = new StreamWriter("Game Score.txt", true);
                w.WriteLine("Difficulty - Hard");
                w.Write("Score: ");
                w.WriteLine(hits.ToString());
                w.Write("Achived on ");
                w.WriteLine(now);
                w.WriteLine(today);
                w.WriteLine();
                w.Close();
                                
                MessageBox.Show("Your score is: " + hits.ToString(), "Game over!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int x = random.Next(this.Width - pictureBox1.Width - 70);
            int y = random.Next(this.Height - pictureBox1.Height - 50);
            pictureBox1.Location = new Point(x, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 gg = new Form1();
            gg.Show();
        }
    }
}
