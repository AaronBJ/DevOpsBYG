using BygDevOpsManager.inventory;
using BygModels.Inventory.dto;
using Microsoft.AspNetCore.Http.HttpResults;
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
            var result = await _inventoryManager.GetAllAsync();
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

        [HttpPost]
        public async Task<IActionResult> Create() {
            var result = await _inventoryManager.InsertAsync();
            var dto = new InventoryResponseDto();
            dto.Id = result.Id;
            dto.Description = result.Description;
            dto.Quantity = result.Quantity;
            dto.Image = result.Image;
            return Ok(dto);
        }
    }
}
