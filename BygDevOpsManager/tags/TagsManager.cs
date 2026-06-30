using BygModels.tags;
using BygModels.tags.dto;
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

        public async Task<IEnumerable<TagsDto>> GetTagsAsync()
        {

            var x = await _tagsRepository.GetAllAsync();

           return x.Select(x => new TagsDto()
           {
               Color = x.Color,
               Details = x.Details,
               Icon = x.Icon,
               Id = x.Id,
               IsDeleted = x.IsDeleted

           }).ToList();
            
            
        
        }
    }
}
