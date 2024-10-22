using EmpView.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpView
{
    public partial class Form1 : Form
    {
        EntityDataModel obj = new EntityDataModel();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Employee> emp = obj.Employees.ToList();
            dataGridView1.DataSource = emp;

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            obj.SaveChanges();
            MessageBox.Show("Data has saved/display successfully");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
