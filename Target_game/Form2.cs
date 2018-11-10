using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace Frog_game
{
    public partial class Form2 : Form
    {
        int counter = 30;
        int hits;
        Random random = new Random();
        WindowsMediaPlayer boom = new WindowsMediaPlayer();
        
        

        public Form2()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            boom.URL = "boom.mp3";
            // textBox1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            Form1 gg = new Form1();
            gg.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hits++;
            label2.Text = hits.ToString();
            
            boom.controls.play();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
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
                MessageBox.Show("Your score is: " +hits.ToString(), "Game over!");

                string today = DateTime.Now.ToString("dd-MM-yyyy");
                string now = DateTime.Now.ToString(("HH:mm:ss"));

                StreamWriter w = new StreamWriter("Game Score.txt", true);
                w.WriteLine("Difficulty - Easy");
                w.Write("Score: ");
                w.WriteLine(hits.ToString());
                w.Write("Achived on ");
                w.WriteLine(now);
                w.WriteLine(today);
                w.WriteLine();
                w.Close();
                // string text = hits.ToString();
                // System.IO.File.AppendAllText(@"C:\Game_score.txt", hits.ToString()+ Environment.NewLine);

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



        private void Form2_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(new Bitmap("dart.png"),100,100);
            this.Cursor= new Cursor(bmp.GetHicon());
            button2.Cursor = Cursors.Default;
            button1.Cursor = Cursors.Default;
        }
    }
}
