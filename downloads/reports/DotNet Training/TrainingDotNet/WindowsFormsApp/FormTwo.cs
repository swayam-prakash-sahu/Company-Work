using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class FormTwo : Form
    {
        TrainingDbContext dbContext = new TrainingDbContext();
        public FormTwo()
        {
            InitializeComponent();
        }

        private void FormTwo_Load(object sender, EventArgs e)
        {
            List<Employee> employees = dbContext.Employees.ToList();
            comboBox.DataSource = employees;
            comboBox.DisplayMember = "EmpName";
            comboBox.ValueMember = "EmpNo";


            List<Department> departments = dbContext.Departments.ToList();
            ListBox listBox = (ListBox)checkedListBox;
            listBox.DataSource = departments;
            listBox.ValueMember = "DeptNo";
            listBox.DisplayMember = "DeptName";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int selected = Convert.ToInt32(comboBox.SelectedValue);
            DateTime dateTime = dateTimePicker.Value;

            Employee employee = dbContext.Employees.Where(x => x.EmpNo == selected).FirstOrDefault();
            employee.JoiningDate = dateTime;
            employee.DeptNo = Convert.ToInt32(checkedListBox.SelectedValue);
            dbContext.SaveChanges();
        }
    }
}
