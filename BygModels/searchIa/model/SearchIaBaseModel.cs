using BygModels.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.searchIa.model
{
    public class SearchIaBaseModel
    {
        public string Image { get; set; }

        public string Title { get; set; }
        public string Link { get; set; }
        public string CategoryColor { get; set; }

        public CategoryAreasEnum Category { get; set; }

    }
}
