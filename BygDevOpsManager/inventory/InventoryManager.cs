using BygModels.inventory;
using BygModels.inventory.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygDevOpsManager.inventory
{
    public class InventoryManager : IInventoryManager
    {
        private IInventoryRepository _inventory;
        public InventoryManager(IInventoryRepository inventory) { 
            _inventory = inventory;
            
        }
        public async Task<IEnumerable<InventoryBaseModel>> GetAllAsync()
        {
            var lista = new List<InventoryBaseModel>();

            var y = await _inventory.getAll();
            return y;
        }

        public Task<InventoryBaseModel> InsertAsync()
        {
            throw new NotImplementedException();
        }
    }
}

