using System;
using System.Collections.Generic;

namespace EmployeeDirectoryWebApp.Models;

public partial class Manager
{
    public int EmployeeId { get; set; }

    public int? ManagerId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<EmployeeProfile> EmployeeProfiles { get; set; } = new List<EmployeeProfile>();

    public virtual EmployeeProfile? ManagerNavigation { get; set; }
}
