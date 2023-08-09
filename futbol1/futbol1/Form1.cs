using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futbol1
{
    public partial class Form1 : Form
    {
      
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
          int i=1;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            x = pictureBox1.Location.X;
            y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.A)
                x -= 5;
            else if (e.KeyCode == Keys.D)
            {
                x += 5;
            }
            else if (e.KeyCode == Keys.W && y > 0)
                y -= 5;
            else if (e.KeyCode == Keys.S && y < 410)
                y += 5;
            pictureBox1.Location = new Point(x, y);


            if ( i<11 && pictureBox2.Location.Y + pictureBox2.Size.Height > pictureBox1.Location.Y)
            {                   
                  
                label5.Text = i.ToString();
                pictureBox1.Location = new Point(a,b);  
                i++;
            
            }
                

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        int x, y,a,b;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             a= pictureBox1.Location.X;
             b = pictureBox1.Location.Y;
        }
    }

    }

