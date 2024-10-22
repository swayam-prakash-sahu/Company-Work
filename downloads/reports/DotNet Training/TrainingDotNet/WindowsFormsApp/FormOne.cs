using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class frmBasic : Form
    {
        public frmBasic()
        {
            InitializeComponent();
        }

        private void frmBasic_Load(object sender, EventArgs e)
        {
            TrainingDbContext dbContext = new TrainingDbContext();
            List<Emp> employees = (from employee in dbContext.Employees
                                   select new Emp
                                   {
                                       EmpNo = employee.EmpNo,
                                       EmpName = employee.EmpName,
                                       DeptNo = employee.DeptNo,
                                       DeptName = employee.Department.DeptName
                                   }).ToList();
            //dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = employees;
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].Width = 200;
            }


        }
    }
}
