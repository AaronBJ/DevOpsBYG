using System;
using System.Collections.Generic;

namespace BygDevOpsData.Models;

public partial class tags
{
    public int id { get; set; }

    public string details { get; set; } = null!;

    public string? color { get; set; }

    public string? iconos { get; set; }

    public bool? is_deleted { get; set; }
}
