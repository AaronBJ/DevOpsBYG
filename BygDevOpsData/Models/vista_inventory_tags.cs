using System;
using System.Collections.Generic;

namespace BygDevOpsData.Models;

public partial class vista_inventory_tags
{
    public int inventory_id { get; set; }

    public string inventory_details { get; set; } = null!;

    public int inventory_quantity { get; set; }

    public string inventory_image { get; set; } = null!;

    public bool inventory_is_deleted { get; set; }

    public int? tags_id { get; set; }

    public string? tags_details { get; set; }

    public string? tags_color { get; set; }

    public string? tags_icons { get; set; }

    public bool? tags_is_deleted { get; set; }
}
