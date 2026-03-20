using System;
using System.Collections.Generic;

namespace BygDevOpsData.Models;

public partial class inventory_tags
{
    public int? inventario_id { get; set; }

    public int? tags_id { get; set; }

    public virtual inventory? inventario { get; set; }

    public virtual tags? tags { get; set; }
}
