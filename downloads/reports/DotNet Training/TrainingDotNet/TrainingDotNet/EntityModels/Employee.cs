namespace TrainingDotNet.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpNo { get; set; }

        [StringLength(20)]
        public string EmpName { get; set; }

        [StringLength(20)]
        public string Job { get; set; }

        public int? Manager { get; set; }

        public DateTime? JoiningDate { get; set; }

        public int? Salary { get; set; }

        public int? Bonus { get; set; }

        public int? DeptNo { get; set; }

        public virtual Department Department { get; set; }
    }
}
