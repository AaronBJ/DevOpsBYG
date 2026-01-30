using BygModels.inventory.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.inventory
{
    public interface IInventoryManager
    {
        public Task<IEnumerable<InventoryBaseModel>> GetAllAsync();
        public Task<InventoryBaseModel> GetAsync(int id);
        public Task<InventoryBaseModel> InsertAsync(InventoryBaseModel model);

        public Task<InventoryBaseModel> UpdateAsync(int id, InventoryBaseModel model);

        public Task DeleteAsync(int id);


    }
}
