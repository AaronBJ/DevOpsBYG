using BygDevOpsData.Data;
using BygDevOpsData.Models;
using BygModels.inventory;
using BygModels.inventory.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
               var objectToReturn = await ctx.inventory.Select(x=> new InventoryBaseModel()
               {
                   Id = x.id,
                   Description=x.details,
                   Quantity=x.quantity.Value,
                   Image=x.imageurl

               }).ToListAsync();
                return objectToReturn;

            } ;
        }

        public async Task<InventoryBaseModel> GetAsync(int id)
        {
            using (var ctx = new AppDbContext()) {
                var objectFromDB = await ctx.inventory.FirstAsync(x => x.id == id);
                var objectToReturn = new InventoryBaseModel();
                objectToReturn.Id = id;
                objectToReturn.Quantity = objectFromDB.quantity.Value;
                objectFromDB.details = objectFromDB.details;
                objectFromDB.imageurl = objectFromDB.imageurl;

                return objectToReturn;
            
            }
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

        public async Task<InventoryBaseModel> UpdateAsync(int id, InventoryBaseModel model)
        {
            using (var ctx = new AppDbContext())
            {

               var RecordToUpdate = await ctx.inventory.FirstAsync(x=>x.id == id);
                RecordToUpdate.details = model.Description;
                RecordToUpdate.quantity = model.Quantity;
                RecordToUpdate.imageurl = model.Image;
                await ctx.SaveChangesAsync();

            }
            return model;
        }
    }
}
