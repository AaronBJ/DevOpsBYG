using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.views
{
    public class InventoryTagsViewBaseModel
    {
        public int InventoryId { get; set; }

        public string InventoryDetails { get; set; } = null!;

        public int InventoryQuantity { get; set; }

        public string InventoryImage { get; set; } = null!;

        public bool InventoryIsDeleted { get; set; }

        public IEnumerable<InventoryTagsViewTagsBaseModel> Tags { get; set; }
    }
}
