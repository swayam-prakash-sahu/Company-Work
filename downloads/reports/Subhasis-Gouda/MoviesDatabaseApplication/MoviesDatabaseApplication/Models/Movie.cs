using System;
using System.Collections.Generic;

namespace MoviesDatabaseApplication.Models;

public partial class Movie
{
    public int MovieId { get; set; }

    public string Title { get; set; } = null!;

    public DateOnly ReleaseDate { get; set; }

    public string Genre { get; set; } = null!;

    public string PlotSynopsis { get; set; } = null!;

    public TimeOnly Runtime { get; set; }

    public string PosterArt { get; set; } = null!;

    public bool IsReleased { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<MovieCast> MovieCasts { get; set; } = new List<MovieCast>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<UserInteraction> UserInteractions { get; set; } = new List<UserInteraction>();
}
