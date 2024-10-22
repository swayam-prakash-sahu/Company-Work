using System;
using System.Collections.Generic;

namespace MoviesDatabaseApplication.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public long Phone { get; set; }

    public bool IsActive { get; set; }

    public int RoleId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual Role? Role { get; set; } = null!;

    public virtual ICollection<UserInteraction> UserInteractions { get; set; } = new List<UserInteraction>();
    public virtual ICollection<Role> Roles { get; set; }= new List<Role>();
}
