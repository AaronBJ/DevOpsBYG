using BygDevOpsManager.inventory;
using BygModels.Inventory.dto;
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
            var result = await _inventoryManager.GetAll();
            var dto = new List<InventoryResponseDto>();
            foreach (var item in result)
            {
                var x = new InventoryResponseDto()
                {
                    Id = item.Id,
                    Description = item.Description,
                    Quantity = item.Quantity,
                    Image = item.Image
                };
                dto.Add(x);
            }
            return Ok(dto);

        
        }
    }
}
