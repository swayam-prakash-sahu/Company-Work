using System;
using System.Collections.Generic;

namespace Blogs_Website_API.Models;

public partial class Blog
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }
}
