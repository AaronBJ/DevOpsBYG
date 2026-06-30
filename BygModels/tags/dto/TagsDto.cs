using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.tags.dto
{
    public class TagsDto
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public string Color { get; set; }
        public bool IsDeleted { get; set; }

        public string Icon { get; set; }
    }
}
