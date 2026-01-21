using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.inventory.model
{
    public class InventoryBaseModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
    }
}
