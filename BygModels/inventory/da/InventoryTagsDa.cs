using BygModels.tags.da;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.inventory.da
{
    public class InventoryTagsDa
    {
        public string Details { get; set; }
       
        public IEnumerable<TagsDa> TagList { get; set; }

        public int InventarioId { get; set; }

    }
}
