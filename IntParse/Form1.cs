using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntParse
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                total *= 10;
                total += textBox1.Text[i] - 48;
            }
            label1.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 0;

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] >= 48 && textBox1.Text[i] <= 57)
                {
                    total *= 10;
                    total += textBox1.Text[i] - 48;
                }
            }
            label1.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int total = 0;

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] > 57)
                {
                    break;
                }
                else if (textBox1.Text[i] < 48)
                {
                    break;
                }
                else
                {
                    total *= 10;
                    total += textBox1.Text[i] - 48;
                }
            }
            label1.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int total = 0;

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] > 57)
                {
                    total = 0;
                    break;
                }
                else if (textBox1.Text[i] < 48)
                {
                    total = 0;
                    break;
                }
                else
                {
                    total *= 10;
                    total += textBox1.Text[i] - 48;
                }
            }
            label1.Text = total.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
