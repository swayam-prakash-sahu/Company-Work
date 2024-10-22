using System;
using System.Collections.Generic;

namespace MoviesDatabaseApplication.Models;

public partial class MovieCast
{
    public int MoviecastId { get; set; }

    public int MovieId { get; set; }

    public int CastId { get; set; }

    public string Role { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual Castcrew Cast { get; set; } = null!;

    public virtual Movie Movie { get; set; } = null!;
}
