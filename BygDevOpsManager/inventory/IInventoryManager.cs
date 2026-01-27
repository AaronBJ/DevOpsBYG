using BygModels.inventory.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygDevOpsManager.inventory
{
    public interface IInventoryManager
    {
        public Task<IEnumerable<InventoryBaseModel>> GetAllAsync();
        public Task<InventoryBaseModel> InsertAsync();
    }
}
