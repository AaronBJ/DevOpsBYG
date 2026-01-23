using System;
using System.Collections.Generic;

namespace BygDevOpsData.Models;

public partial class inventory
{
    public int id { get; set; }

    public string? details { get; set; }

    public int? quantity { get; set; }

    public string? imageurl { get; set; }
}
