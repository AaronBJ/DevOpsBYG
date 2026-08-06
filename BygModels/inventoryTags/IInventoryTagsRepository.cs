using System;
using System.Collections.Generic;
using System.Text;
using BygModels.inventory.da;

namespace BygModels.inventoryTags
{
    public interface IInventoryTagsRepository
    {
        public Task InsertAsync(int inventoryId, int tagsId);

        public Task DeleteAllAsync(int inventoryId);

        public Task<InventoryTagsDa> GetInventoryTagsAsync(int inventoryId);
        

    }
}
