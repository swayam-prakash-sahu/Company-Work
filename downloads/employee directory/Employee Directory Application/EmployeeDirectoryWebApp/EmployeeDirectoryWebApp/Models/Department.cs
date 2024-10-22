using System;
using System.Collections.Generic;

namespace EmployeeDirectoryWebApp.Models;

public partial class Department
{
    public int DeptId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<EmployeeProfile> EmployeeProfiles { get; set; } = new List<EmployeeProfile>();
}
