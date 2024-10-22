using System;
using System.Collections.Generic;

namespace EmployeeDirectoryWebApp.Models;

public partial class ContactInformation
{
    public int ContactId { get; set; }

    public int? EmployeeId { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? OfficeLocation { get; set; }

    public string? SocialMediaProfiles { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual EmployeeProfile? Employee { get; set; }
}
