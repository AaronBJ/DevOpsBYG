using BygModels.tags.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.tags
{
    public interface ITagsManager
    {
        public Task<IEnumerable<string>> GetTagsAsync();

    }
}
