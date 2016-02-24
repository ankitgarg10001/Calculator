using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string a = null;
        float res = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                res=(float.Parse(textBox1.Text) + float.Parse(textBox2.Text));
                textBox3.Text = textBox2.Text + "+" + textBox1.Text + "=" + res;
                a += textBox2.Text + "+" + textBox1.Text + " = ";
                textBox1.Text=res.ToString();
                textBox2.Text="0";

            }
            else
            {
                res = ((float.Parse(textBox1.Text) + float.Parse(textBox2.Text)));
                textBox3.Text = textBox1.Text + " + " + textBox2.Text + " = " +res ;
                a += textBox1.Text + "+" + textBox2.Text + " = ";
                textBox1.Text = res.ToString();
                textBox2.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                res=(float.Parse(textBox2.Text) - float.Parse(textBox1.Text));
                textBox3.Text = textBox2.Text + "-" + textBox1.Text + "=" + res;
                a += textBox2.Text + "-" + textBox1.Text + " = ";
                textBox1.Text = res.ToString();
                    
                textBox2.Text="0";
            }
            else
            {
                res = ((float.Parse(textBox1.Text) - float.Parse(textBox2.Text)));
                textBox3.Text = textBox1.Text + " - " + textBox2.Text + " = " + res;
                a += textBox1.Text + "-" + textBox2.Text + " = ";
                textBox1.Text = res.ToString(); 
                textBox2.Text = "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                res = ((float.Parse(textBox2.Text) / float.Parse(textBox1.Text)));
                textBox3.Text = textBox2.Text + "/" + textBox1.Text + "=" + res;
                a += textBox2.Text + "/" + textBox1.Text + " = ";
                textBox1.Text = res.ToString();
                textBox2.Text="1";
            }
            else
            {
                res = ((float.Parse(textBox1.Text) / float.Parse(textBox2.Text)));
                textBox3.Text = textBox1.Text + " / " + textBox2.Text + " = " + res ;
                a += textBox1.Text + "/" + textBox2.Text + " = ";
                textBox1.Text = res.ToString();
                textBox2.Text="1";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                res=((float.Parse(textBox2.Text) * float.Parse(textBox1.Text)));
                textBox3.Text = textBox2.Text + "*" + textBox1.Text + "=" + res;
                a += textBox2.Text + "*" + textBox1.Text + " = ";
                textBox1.Text = res.ToString();
                textBox2.Text="1";
            }
            else
            {res=((float.Parse(textBox1.Text) * float.Parse(textBox2.Text)));
                textBox3.Text = textBox1.Text + " * " + textBox2.Text + " = " + res;
                a += textBox1.Text + "*" + textBox2.Text + " = "; 
                textBox1.Text = res.ToString();
                textBox2.Text="1";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1 / float.Parse(textBox1.Text)).ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = (1 / float.Parse(textBox2.Text)).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show(a +"    "+ res);
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

        
}
