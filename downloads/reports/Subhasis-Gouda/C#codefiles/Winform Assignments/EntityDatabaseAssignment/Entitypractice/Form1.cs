using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entitypractice.EntityModels;
using System.Data.Entity;
using System.Runtime.InteropServices;
namespace Entitypractice
{
    public partial class Form1 : Form
    {
        TrainingDbEntity tde = new TrainingDbEntity();
        
        
        public Form1()
        {
            InitializeComponent();
            
            List<Employee> source = tde.Employees.ToList();
            dataGridView1.DataSource = source;
            comboBox1.DataSource = source;
            comboBox1.DisplayMember = "EmpName";
            comboBox1.ValueMember = "EmpNo";
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tde.SaveChanges();
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Jobtb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Joiningtb.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                Depttb.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();             
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime joiningDate = DateTime.Parse(Joiningtb.Text);
            int currentYear = DateTime.Now.Year;
            int experience = currentYear - joiningDate.Year;
            Experiencetb.Text = experience.ToString();
            label3.Text = "years";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Employee selectedEmployee = (Employee)comboBox1.SelectedItem;
                Jobtb.Text = selectedEmployee.Job;
                Joiningtb.Text = selectedEmployee.JoiningDate.ToString();
                Depttb.Text = selectedEmployee.DeptNo.ToString();
            }
        }
    }
}
