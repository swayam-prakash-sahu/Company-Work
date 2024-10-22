using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Emp
    {
        [DisplayName("Employee Id")]
        public int EmpNo { get; set; }

        [DisplayName("Employee Name")]
        public string EmpName { get; set; }

        [DisplayName("Department Id")]
        public int? DeptNo { get; set; }
        [DisplayName("Department Name")]
        public string DeptName { get; set; }
    }
}
