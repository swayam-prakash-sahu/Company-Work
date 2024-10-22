using System;
using System.Collections.Generic;

namespace MoviesDatabaseApplication.Models;

public partial class UserInteraction
{
    public int UserId { get; set; }

    public int MovieId { get; set; }

    public bool Watchlist { get; set; }

    public bool Favorite { get; set; }

    public int Views { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public int InteractId { get; set; }

    public virtual Movie Movie { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
