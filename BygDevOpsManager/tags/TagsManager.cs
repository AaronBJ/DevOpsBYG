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

        public async Task<IEnumerable<string>> GetTagsAsync()
        {

            var x = await _tagsRepository.GetAllAsync();

           return x.Select(x => x.Details).ToList();
            
            
        
        }
    }
}
