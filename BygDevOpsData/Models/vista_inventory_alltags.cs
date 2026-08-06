using System;
using System.Collections.Generic;

namespace BygDevOpsData.Models;

public partial class vista_inventory_alltags
{
    public int inventory_id { get; set; }

    public string inventory_detail { get; set; } = null!;

    public int tag_id { get; set; }

    public string tag_detail { get; set; } = null!;

    public string? color { get; set; }

    public string? icons { get; set; }

    public int is_enable { get; set; }
}
