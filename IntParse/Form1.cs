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
            //variable that stores the value that is showed at the conversions success. 
            //For-loop that assigns the value "0" to variable i, and runs as long as mentioned variable is has a smaller value than
            //the number of symbols in textBox1.
            //Also increases the value of i by 1 each time the loop runs. 
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                total *= 10;
                total += textBox1.Text[i] - 48;
                //Each time the loop runs every character is read, and if the character, for instance "a", which the computer knows as "97"
                //is outputted as 49, because 97 - 48 = 49.
            }
            label1.Text = total.ToString();
            //Convets the variable to a string and applies it as the text in Label1.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 0;

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                //Only shows a conversion value when an symbols avlue is bigger than or is 48, and lesser than or is 57,to
                //skip letters and only convet numbers.
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
                //The for loop is stopped if value of the input is higher that 57 or less than 48, to stop the 
                //loop when encountering anyhting else than a number.
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
                //The loop is stopped if the input if higher than 57 or less than 48,
                //essentially if it encounters something else than a number, and displays the conversion value as 0.
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
