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
    public partial class Form1 : Form
    {
        
       
        
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            player.URL = "track.mp3";

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;

            StreamWriter w = new StreamWriter("Game Score.txt",true);
            w.Write("Name: ");
            w.WriteLine(textBox1.Text);
            w.Close();


            if (!checkBox1.Checked && !checkBox2.Checked )
            {
                MessageBox.Show("Select difficulty first!", "Error");
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text)){
                MessageBox.Show("Please enter your name!", "Error");
            }
            
            if(checkBox1.Checked  && !string.IsNullOrWhiteSpace(textBox1.Text)){

                this.Hide();
                Form2 ss = new Form2();
                ss.Show();
                player.controls.stop();


            }
            if(checkBox2.Checked && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                this.Hide();
                Form3 fr = new Form3();
                fr.Show();
                player.controls.stop();


                }
            if (checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("Error", "Select one difficulty!");
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }
    }
}
