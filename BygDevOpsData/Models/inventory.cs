using System;
using System.Collections.Generic;

namespace BygDevOpsData.Models;

public partial class inventory
{
    public int id { get; set; }

    public string details { get; set; } = null!;

    public int quantity { get; set; }

    public string imageurl { get; set; } = null!;

    public bool is_deleted { get; set; }
}
