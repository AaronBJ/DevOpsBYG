using BygModels.inventory.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.inventory
{

    public interface IInventoryRepository
    {
        public Task<IEnumerable<InventoryBaseModel>> getAll();
    }
}
