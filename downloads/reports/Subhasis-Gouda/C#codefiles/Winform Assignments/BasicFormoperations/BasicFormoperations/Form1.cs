using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BasicFormoperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 5;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Checklisttb.Text = "";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                Checklisttb.Text += item.ToString()+",";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Gendertb.Text = radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Gendertb.Text = radioButton2.Text;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            listBox1.Items.Add(selectedItem);
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textlbl.Font = new Font(textlbl.Font.FontFamily, (int)numericUpDown1.Value);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            datetb.Text = dateTimePicker1.Value.ToShortDateString();
            timetb.Text = dateTimePicker1.Value.ToShortTimeString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/kamleshrao-gs/get-2024-microsoft/tree/main/workarea/Subhasis-Gouda";
            System.Diagnostics.Process.Start(url);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                progressBar1.Value = 0;
            }
        }

    }
}
