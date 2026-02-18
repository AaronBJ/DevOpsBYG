using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.views
{
    public class InventoryTagsViewTagsBaseModel
    {
        public int TagsId { get; set; }

        public string TagsDetails { get; set; } 

        public string? TagsColor { get; set; }

        public string? TagsIcons { get; set; }

        public bool? TagsIsDeleted { get; set; }
    }
}
