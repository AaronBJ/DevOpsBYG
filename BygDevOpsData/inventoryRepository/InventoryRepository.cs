using BygDevOpsData.Data;
using BygDevOpsData.Models;
using BygModels.inventory;
using BygModels.inventory.model;
using BygModels.tags.model;
using BygModels.views;
using Microsoft.EntityFrameworkCore;

namespace BygDevOpsData.inventoryRepository
{
    public class InventoryRepository : IInventoryRepository
    {
        public async Task<IEnumerable<InventoryTagsViewBaseModel>> GetAllAsync()
        {
            using (var ctx = new AppDbContext())
            {
                var objectToReturn = await ctx.vista_inventory_tags.
                     //Where(x=>!x.inventory_is_deleted).
                     Select(x => new InventoryTagsViewBaseModel()
                     {
                         InventoryId = x.inventory_id,
                         InventoryDetails = x.inventory_details,
                         InventoryImage = x.inventory_image,
                         InventoryIsDeleted = x.inventory_is_deleted,
                         InventoryQuantity = x.inventory_quantity,
                         Tags = new List<InventoryTagsViewTagsBaseModel>()
                    {
                      new InventoryTagsViewTagsBaseModel()
                      {
                          TagsColor = x.tags_color,
                          TagsIcons = x.tags_icons,
                          TagsDetails = x.tags_details,
                          TagsId = x.tags_id==null?0:x.tags_id.Value,
                          TagsIsDeleted = x.tags_is_deleted,
                      }

                    }


                     }).ToListAsync();

                return objectToReturn;

            }
            ;
        }

        public async Task<InventoryBaseModel> GetAsync(int id)
        {
            using (var ctx = new AppDbContext())
            {
                var objectToReturn = await ctx.inventory
                .Where(x => x.id == id)
                .Select(x => new InventoryBaseModel
                {
                    Id = x.id,
                    Quantity = x.quantity,
                    Description = x.details,
                    Image = x.imageurl,
                    Tags = x.inventory_tags
                        .Select(it => new TagsBaseModel
                        {
                            Color = it.tags.color,
                            Icon = it.tags.iconos,
                            Details = it.tags.details,

                        })
                        .ToList()
                })
                .FirstAsync();

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

                var RecordToUpdate = await ctx.inventory.FirstAsync(x => x.id == id);
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
