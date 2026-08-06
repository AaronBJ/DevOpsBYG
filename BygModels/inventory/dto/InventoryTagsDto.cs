using BygModels.tags.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.inventory.dto
{
    public class InventoryTagsDto
    {
        public string Details { get; set; }

        public IEnumerable<TagsDto> TagList { get; set; }
        public int InventarioId { get; set; }

    }
}
