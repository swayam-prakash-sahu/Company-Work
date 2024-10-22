using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private double a;
        private double b;
        private string c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result;
            if (c == "+")
            {
                result = a + b;
                label4.Text = result.ToString();
            }
            else if (c == "-")
            {
                result = a - b;
                label4.Text = result.ToString();
            }
            else if (c == "*")
            {
                result = a * b;
                label4.Text = result.ToString();
            }
            else if (c == "/")
            {
                result = a / b;
                label4.Text = result.ToString();
            }
            else if (c == "%")
            {
                result = a % b;
                label4.Text = result.ToString();
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b = double.Parse(textBox2.Text);    
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            c = textBox3.Text;
        }
    }
}
