using BygModels.inventory.model;
using BygModels.tags.da;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.inventory.da
{
    public class InventoryDetailsDa
    {
        public int TagId { get; set; }

        public string TagDetails { get; set; }

        public string TagColor { get; set; }

        public bool TagIsDeleted { get; set; }

        public string TagIcon { get; set; }

        public bool TagIsEnable { get; set; }

        public int InventoryId { get; set; }

        public string InventoryDescription { get; set; }

        public int InventoryQuantity { get; set; }

        public string InventoryImage { get; set; }

    }
}
