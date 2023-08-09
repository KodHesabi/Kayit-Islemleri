using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev1
{ 
    
   
    public partial class Form1 : Form
    {

        int listIndex;
        public Form1()
            
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
             listIndex = listBox1.SelectedIndex;
            if(listBox1.SelectedIndex!=-1)
            {
                textBox1.Text = listBox1.Items[listIndex].ToString();
                textBox2.Text = listBox2.Items[listIndex].ToString();
                textBox3.Text = listBox3.Items[listIndex].ToString();
                textBox4.Text = listBox4.Items[listIndex].ToString();
                textBox5.Text = listBox5.Items[listIndex].ToString();
               
                button5.Visible = true;
            }

            
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listIndex = listBox1.SelectedIndex;
            if (listIndex!=-1)
            {

            listBox1.Items.RemoveAt(listIndex);
            listBox2.Items.RemoveAt(listIndex);
            listBox3.Items.RemoveAt(listIndex);
            listBox4.Items.RemoveAt(listIndex);
            listBox5.Items.RemoveAt(listIndex); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")

            {
                label11.Text = "Textbox1'in içi boş....";
                label12.Text = "Lütfen Boş alanları doldurup Tekrar deneyin!!!!";
            }
            else if (textBox2.Text=="")

            {
                label11.Text = "Textbox2'nin içi boş....";
                label12.Text = "Lütfen Boş alanları doldurup Tekrar deneyin!!!!";
            }
            else if (textBox3.Text=="")
            {
                label11.Text = "Textbox'3ün içi boş....";
                label12.Text = "Lütfen Boş alanları doldurup Tekrar deneyin!!!!";
            }
            else if (textBox4.Text=="")
            {
                label11.Text = "Textbox4'ün içi boş....";
                label12.Text = "Lütfen Boş alanları doldurup Tekrar deneyin!!!!";
            }
            else if(textBox5.Text=="")
            {
                label11.Text = "Textbox5'in içi boş....";
                label12.Text = "Lütfen Boş alanları doldurup Tekrar deneyin!!!!";
            }
            else
            {
                 
              listBox1.Items.Add(textBox1.Text);
              listBox2.Items.Add(textBox2.Text);
              listBox3.Items.Add(textBox3.Text);
              listBox4.Items.Add(textBox4.Text);
              listBox5.Items.Add(textBox5.Text);

              textBox1.Text = "";
              textBox2.Text = "";
              textBox3.Text = "";
              textBox4.Text = "";
              textBox5.Text = "";
              label11.Text = "";
              label12.Text = "";

            }


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                label11.Text = "Textbox1'in içi boş....";
                label12.Text = "Lütfen Boş Kutu bırakmayın!!!!";
            }
            else if (textBox2.Text == "")
            {
                label11.Text = "Textbox2'nin içi boş....";
                label12.Text = "Lütfen Boş Kutu Bırakmayın!!!!";
            }
            else if (textBox3.Text == "")
            {
                label11.Text = "Textbox3'ün içi boş....";
                label12.Text = "Lütfen Boş Kutu Bırakmayın!!!!";
            }
            else if (textBox4.Text == "")
            {
                label11.Text = "Textbox4'ün içi boş....";
                label12.Text = "Lütfen Boş Kutu Bırakmayın!!!!";
            }
            else if (textBox5.Text == "")
            {
                label11.Text = "Textbox5'in içi boş....";
                label12.Text = "Lütfen Boş Kutu Bırakmayın!!!!";
            }
            else
            {
                listBox1.Items[listIndex] = textBox1.Text;
                listBox2.Items[listIndex] = textBox2.Text;
                listBox3.Items[listIndex] = textBox3.Text;
                listBox4.Items[listIndex] = textBox4.Text;
                listBox5.Items[listIndex] = textBox5.Text;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                label11.Text = "";
                label12.Text = "";

                button5.Visible = false;
            }

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
