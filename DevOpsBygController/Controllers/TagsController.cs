using BygModels.tags;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsBygController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TagsController: ControllerBase
    {
        private ITagsManager _tagsManager;

        public TagsController(ITagsManager tagsManager)
        {
            _tagsManager = tagsManager;
        }

        [HttpGet(Name = "GetAllTags")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _tagsManager.GetTagsAsync();

            return Ok(result); 

        }

    }
}
