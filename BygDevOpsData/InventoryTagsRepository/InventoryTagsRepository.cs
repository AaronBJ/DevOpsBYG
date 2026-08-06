using BygDevOpsData.Data;
using BygDevOpsData.Models;
using BygModels.inventory.da;
using BygModels.inventoryTags;
using BygModels.tags.da;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygDevOpsData.InventoryTagsManager
{
    public class InventoryTagsRepository : IInventoryTagsRepository
    {
        public async Task DeleteAllAsync(int inventoryId)
        {
            using (var ctx = new AppDbContext())
            {
                var recordsToDelete = await ctx.inventory_tags
                    .Where(x => x.inventario_id == inventoryId)
                    .ExecuteDeleteAsync();
            }
        }

        public async Task InsertAsync(int inventoryId, int tagsId)
        {
            var newRecord = new inventory_tags();
            newRecord.tags_id = tagsId;
            newRecord.inventario_id = inventoryId;

            using (var ctx = new AppDbContext())
            {
                ctx.inventory_tags.Add(newRecord);
                await ctx.SaveChangesAsync();
            };
        }

        public async Task<InventoryTagsDa> GetInventoryTagsAsync(int inventoryId)
        {
            var objectToReturn = new InventoryTagsDa();

            using (var ctx = new AppDbContext())
            {
                var temporal = await ctx.vista_inventory_alltags
                    .Where(x => x.inventory_id == inventoryId)
                    .ToListAsync();

                objectToReturn.Details = temporal.FirstOrDefault().inventory_detail;
                objectToReturn.InventarioId = inventoryId;
                objectToReturn.TagList = temporal.Select(x => new TagsDa()
                {
                    Color = x.color,
                    Details = x.tag_detail,
                    Icon = x.icons,
                    Id = x.tag_id,
                    IsEnable = x.is_enable == 1 ? true : false
                });
            }

            return objectToReturn;
        }
    }
}
