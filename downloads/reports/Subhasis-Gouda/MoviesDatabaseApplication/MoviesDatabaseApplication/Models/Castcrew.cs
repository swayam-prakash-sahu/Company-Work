using System;
using System.Collections.Generic;

namespace MoviesDatabaseApplication.Models;

public partial class Castcrew
{
    public int CastId { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly Birthdate { get; set; }

    public string Biography { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<MovieCast> MovieCasts { get; set; } = new List<MovieCast>();
}
