using BygModels.tags.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.inventory.da
{
    public class InventoryTagsDa
    {
        public string Details { get; set; }
       
        public IEnumerable<TagsDto> TagList { get; set; }

        public int InventarioId { get; set; }

    }
}
