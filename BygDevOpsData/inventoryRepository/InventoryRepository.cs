using BygDevOpsData.Data;
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
        public async Task<IEnumerable<InventoryBaseModel>> getAll()
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
    }
}
