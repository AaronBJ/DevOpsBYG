using BygModels.inventory;
using BygModels.inventory.model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

            var y = await _inventory.GetAllAsync();
            return y;
        }

        public async Task<InventoryBaseModel> InsertAsync(InventoryBaseModel model)
        {
            var modelToReturn = await _inventory.InsertAsync(model);

            return modelToReturn;
        }

        public async Task<InventoryBaseModel> UpdateAsync(int id, InventoryBaseModel model)
        {
            var elementsToReturn = await _inventory.UpdateAsync(id, model);

            return elementsToReturn;
        }

    }
}

