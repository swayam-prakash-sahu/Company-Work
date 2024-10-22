using System;
using System.Collections.Generic;

namespace EmployeeDirectoryWebApp.Models;

public partial class EmployeeProfile
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public int? DesignationId { get; set; }

    public int? DeptId { get; set; }

    public int? ManagerId { get; set; }

    public string? EmployeeProfilePic { get; set; }

    public string? EmploymentStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<ContactInformation> ContactInformations { get; set; } = new List<ContactInformation>();

    public virtual Department? Dept { get; set; }

    public virtual Designation? Designation { get; set; }

    public virtual Manager? Manager { get; set; }

    public virtual ICollection<Manager> Managers { get; set; } = new List<Manager>();
}
