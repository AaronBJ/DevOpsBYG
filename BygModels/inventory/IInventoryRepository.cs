using BygModels.inventory.model;
using BygModels.views;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygModels.inventory
{

    public interface IInventoryRepository
    {
        public Task<IEnumerable<InventoryTagsViewBaseModel>> GetAllAsync();
        public Task<InventoryBaseModel> InsertAsync(InventoryBaseModel model);

        public Task<InventoryBaseModel> UpdateAsync( int id , InventoryBaseModel model);

        public Task<InventoryBaseModel> GetAsync(int id);

        public Task DeleteAsync(int id);
    }
}
