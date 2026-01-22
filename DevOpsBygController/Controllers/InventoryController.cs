using BygDevOpsManager.inventory;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsBygController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        IInventoryManager _inventoryManager;

        public InventoryController(IInventoryManager inventoryManager)
        {
            _inventoryManager = inventoryManager;
        }

        [HttpGet(Name = "GetAllInventory")]

        public async Task<IActionResult> Get() { 
            var result = _inventoryManager.GetAll();
            return Ok(result);

        
        }
    }
}
