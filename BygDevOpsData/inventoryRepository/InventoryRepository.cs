using BygDevOpsData.Data;
using BygDevOpsData.Models;
using BygModels.inventory;
using BygModels.inventory.model;
using BygModels.views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BygDevOpsData.inventoryRepository
{
    public class InventoryRepository : IInventoryRepository
    {
        public async Task<IEnumerable<InventoryTagsView>> GetAllAsync()
        {
            using (var ctx = new AppDbContext())
            {
               var objectToReturn = await ctx.vista_inventory_tags.Where(x=>!x.inventory_is_deleted).Select(x=> new InventoryTagsView()
               {
                   InventoryId = x.inventory_id,
                   InventoryDetails = x.inventory_details,
                   InventoryImage = x.inventory_image,
                   InventoryIsDeleted = x.inventory_is_deleted,
                   InventoryQuantity = x.inventory_quantity,
                   TagsColor = x.tags_color,
                   TagsDetails = x.tags_details,
                   TagsIcons = x.tags_icons,
                   TagsId = x.tags_id,
                   TagsIsDeleted = x.tags_is_deleted,


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
                objectToReturn.Quantity = objectFromDB.quantity;
                objectToReturn.Description = objectFromDB.details;
                objectToReturn.Image = objectFromDB.imageurl;

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

        public async Task DeleteAsync(int id)
        {
            using (var ctx = new AppDbContext())
            {

                var RecordToUpdate = await ctx.inventory.FirstAsync(x => x.id == id);
                RecordToUpdate.is_deleted = true;
                await ctx.SaveChangesAsync();

            }

        }
    }
}
