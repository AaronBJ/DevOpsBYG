using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.views
{
    public class InventoryTagsView
    {
        public int InventoryId { get; set; }

        public string InventoryDetails { get; set; } = null!;

        public int InventoryQuantity { get; set; }

        public string InventoryImage { get; set; } = null!;

        public bool InventoryIsDeleted { get; set; }

        public int TagsId { get; set; }

        public string TagsDetails { get; set; } = null!;

        public string? TagsColor { get; set; }

        public string? TagsIcons { get; set; }

        public bool? TagsIsDeleted { get; set; }
    }
}
