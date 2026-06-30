using BygModels.tags.dto;
using BygModels.tags.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.tags
{
    public interface ITagsManager
    {
        public Task<IEnumerable<TagsDto>> GetTagsAsync();

    }
}
