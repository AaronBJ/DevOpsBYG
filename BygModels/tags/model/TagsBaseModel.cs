using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.tags.model
{
    public class TagsBaseModel
    {
        public int Id { get; set; }
        public string Details {  get; set; }
        public string Color {  get; set; }
        public bool IsDeleted {  get; set; }

        public string Icon {  get; set; }
    }
}
