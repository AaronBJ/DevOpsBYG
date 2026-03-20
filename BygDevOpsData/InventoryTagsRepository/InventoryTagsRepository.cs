using BygDevOpsData.Data;
using BygDevOpsData.Models;
using BygModels.inventoryTags;
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
                    .ToListAsync();

                ctx.inventory_tags.RemoveRange(recordsToDelete);

                await ctx.SaveChangesAsync();
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
    }
}
