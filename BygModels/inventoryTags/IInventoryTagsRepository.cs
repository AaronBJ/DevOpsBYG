using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.inventoryTags
{
    public interface IInventoryTagsRepository
    {
        public Task InsertAsync(int inventoryId, int tagsId);
        public Task DeleteAllAsync(int inventoryId);
        

    }
}
