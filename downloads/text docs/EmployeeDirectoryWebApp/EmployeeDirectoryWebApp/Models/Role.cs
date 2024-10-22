using System;
using System.Collections.Generic;

namespace EmployeeDirectoryWebApp.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<UserAuthentication> UserAuthentications { get; set; } = new List<UserAuthentication>();
}
