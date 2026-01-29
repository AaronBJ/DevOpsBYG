using BygDevOpsData.Data;
using BygDevOpsData.Models;
using BygModels.inventory;
using BygModels.inventory.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BygDevOpsData.inventoryRepository
{
    public class InventoryRepository : IInventoryRepository
    {
        public async Task<IEnumerable<InventoryBaseModel>> GetAllAsync()
        {
            using (var ctx = new AppDbContext())
            {
               var x = await ctx.inventory.Select(x=> new InventoryBaseModel()
               {
                   Id = x.id,
                   Description=x.details,
                   Quantity=x.quantity.Value,
                   Image=x.imageurl

               }).ToListAsync();
                return x;

            } ;
        }

        public async Task<InventoryBaseModel> InsertAsync(InventoryBaseModel model)
        {
            var newRecord = new inventory();
            newRecord.details = model.Description;
            newRecord.quantity = model.Quantity;
            newRecord.imageurl = model.Image;
            using (var ctx = new AppDbContext())
            {

                ctx.inventory.Add(newRecord);
                await ctx.SaveChangesAsync();
               model.Id = newRecord.id;

            }
            return model;
        }

        public Task<InventoryBaseModel> UpdateAsync(int id, InventoryBaseModel model)
        {
            throw new NotImplementedException();
        }
    }
}
