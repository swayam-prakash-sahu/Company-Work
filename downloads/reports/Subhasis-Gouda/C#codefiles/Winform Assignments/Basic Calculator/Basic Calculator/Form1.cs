using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        private double a = 0;
        private double b = 0;
        private double Number = 0;
        private double result = 0;
        private string Operator = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Display(int number)
        {
            if (result != 0)
            {
                result = 0;
                Number = 0;
                Operator = "";
                textBox1.Text = "";
            }
            textBox1.Text += number.ToString();
            Number = double.Parse(textBox1.Text);
        }
        private void Adddecimal()
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }
        private void ArithmaticOperation()
        {
            switch (Operator)
            {
                case "+":
                    result = a + b;
                    
                    break;
                case "-":
                    result = a - b; 
                   
                    break;
                case "*":
                    result = a * b;
                    
                    break;
                case "/":
                    if (b != 0)
                    {
                        result = a/b;
                      
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.");
                    }
                    break;
                case "%":
                    result = a % b;
                    
                    break;
                default:
                    result = b;                    
                    break;
            }

            textBox1.Text = result.ToString();
            Number = 0; // Reset Number for next input
        }
        private void button18_Click(object sender, EventArgs e)
        {
            //button for mod
            a = Number;
            Operator = "%";
            textBox2.Text = a.ToString() +" "+Operator+" ";
            textBox1.Text = "";


        }
        private void button17_Click(object sender, EventArgs e)
        {
            //button for equals

            b = Number;
            textBox2.Text += (b.ToString() + " = ");
            ArithmaticOperation();
            Operator = "";

           

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //addition
            a = Number;
            Operator = "+";
            textBox2.Text = a.ToString() + " " + Operator + " ";
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //substarction
            a = Number;
            Operator = "-";
            textBox2.Text = a.ToString() + " " + Operator + " ";
            textBox1.Text = "";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //multiplication   
            a = Number;
            Operator = "*";
            textBox2.Text = a.ToString() + " " + Operator + " ";
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //division
            a = Number;
            Operator = "/";
            textBox2.Text = a.ToString() + " " + Operator + " ";
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //clearbutton
            Number = 0;
            result = 0;
            Operator = "";
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Display(0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Display(9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display(8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display(7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display(6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display(4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display(1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
