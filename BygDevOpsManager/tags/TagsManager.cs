using BygModels.tags;
using BygModels.tags.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygDevOpsManager.tags
{
    public class TagsManager : ITagsManager
    {
        private ITagsRepository _tagsRepository;
        public TagsManager(ITagsRepository tagsRepository)
        {
            _tagsRepository = tagsRepository;
        }

        public async Task<IEnumerable<TagsBaseModel>> GetTagsAsync()
        {

           return await _tagsRepository.GetAllAsync();
            
        
        }
    }
}
