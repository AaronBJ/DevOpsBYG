using BygModels.searchIa;
using Microsoft.AspNetCore.Mvc;


namespace DevOpsBygController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IaController: ControllerBase
    {
        ISearchIaManager _searchIaManager;

        public IaController(ISearchIaManager searchIaManager)
        {
            _searchIaManager = searchIaManager;
        }


        
    }
}
