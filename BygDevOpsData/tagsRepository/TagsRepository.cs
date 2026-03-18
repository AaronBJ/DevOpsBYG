using BygDevOpsData.Data;
using BygDevOpsData.Models;
using BygModels.tags;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygDevOpsData.tagsRepository
{
    public class TagsRepository: ITagsRepository
    {
        public async Task<bool> IsExistsAsync(string detail)
        {
            if(string.IsNullOrEmpty(detail))
            {

                return false;
            }
            using (var ctx = new AppDbContext())
            {
                var objectfromDB = await ctx.tags.AnyAsync(x => x.details == detail);

                
                
                return objectfromDB;

            }

        }

        public async Task<int> InsertTagsAsync(string detail, string icon, string color)
        {
            var newRecord = new tags();
            newRecord.details = detail;
            newRecord.iconos = icon;
            newRecord.color = color;
            using (var ctx = new AppDbContext())
            {
                ctx.tags.Add(newRecord);
                await ctx.SaveChangesAsync();
                return newRecord.id;

            }

        }
    }
}
