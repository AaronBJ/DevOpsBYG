using BygModels.inventory;
using BygModels.inventory.model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        public async Task<InventoryBaseModel> GetAsync(int id)
        {
           return await _inventory.GetAsync(id);
        }

        public async Task<InventoryBaseModel> InsertAsync(InventoryBaseModel model)
        {
            var modelToReturn = await _inventory.InsertAsync(model);

            return modelToReturn;
        }


        public async Task<InventoryBaseModel> UpdateAsync(int id, InventoryBaseModel model)
        {
            var elementToUpdate = await _inventory.GetAsync(id);
            if (elementToUpdate != null)
            {
                var elementsToReturn = await _inventory.UpdateAsync(id, model);

                return elementsToReturn;
            }
            else { return null; }
        }

        public async Task DeleteAsync(int id)
        {
            var elementToUpdate = await _inventory.GetAsync(id);
            if (elementToUpdate != null)
            {
                await _inventory.DeleteAsync(id);

            }
            

        }

    }
}

