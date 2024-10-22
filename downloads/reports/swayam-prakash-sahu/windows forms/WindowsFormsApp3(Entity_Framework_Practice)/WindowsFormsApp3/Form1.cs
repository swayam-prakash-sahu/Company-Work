using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet.DEPT' table. You can move, or remove it, as needed.
            this.dEPTTableAdapter.Fill(this.trainingDBDataSet.DEPT);
            // TODO: This line of code loads data into the 'trainingDBDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.trainingDBDataSet.EMPLOYEE);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string emp_sal = Convert.ToString(comboBox1.SelectedValue);
            textBox5.Text = emp_sal.ToString();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eMPLOYEETableAdapter.FillBy(this.trainingDBDataSet.EMPLOYEE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] columnData = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();

            
            textBox1.Text = columnData.Sum().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] columnData = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();

            textBox2.Text = columnData.Average().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] columnData = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();

            textBox3.Text = columnData.Max().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            int[] columnData = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();

            textBox4.Text = columnData.Min().ToString();

        }
    }
}
