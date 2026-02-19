using BygModels.inventory;
using BygModels.inventory.model;
using BygModels.tags.model;
using BygModels.views;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BygDevOpsManager.inventory
{
    public class InventoryManager : IInventoryManager
    {
        private IInventoryRepository _inventory;
        public InventoryManager(IInventoryRepository inventory) { 
            _inventory = inventory;
            
        }

        /// <summary>
        /// esta funcion trae todos los elementos de la base de datos
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<InventoryBaseModel>> GetAllAsync()
        {
            var lista = new List<InventoryBaseModel>();

            var y = await _inventory.GetAllAsync();
            foreach (var item in y)
            {

                var tmp = lista.Find(x => x.Id == item.InventoryId);

                if (tmp == null) {
                    var ListaDeTags = new List<TagsBaseModel>();
                    ListaDeTags.Add(Convert(item.Tags.FirstOrDefault()));
                    lista.Add(new InventoryBaseModel()
                    {
                        Id = item.InventoryId,
                        Description = item.InventoryDetails,
                        Image = item.InventoryImage,
                        Quantity = item.InventoryQuantity,
                        Tags = ListaDeTags,


                    });

                }
                else
                {
                    tmp.Tags.Add(Convert(item.Tags.FirstOrDefault()));
                }
                

                
 
            }
            return lista;
        }

        public async Task<InventoryBaseModel> GetAsync(int id)
        {
           return await _inventory.GetAsync(id);
        }

        public async Task<InventoryBaseModel> InsertAsync(InventoryBaseModel model)
        {
            var modelToReturn = await _inventory.InsertAsync(model);

            return modelToReturn;
        }


        public async Task<InventoryBaseModel> UpdateAsync(int id, InventoryBaseModel model)
        {
            var elementToUpdate = await _inventory.GetAsync(id);
            if (elementToUpdate != null)
            {
                var elementsToReturn = await _inventory.UpdateAsync(id, model);

                return elementsToReturn;
            }
            else { return null; }
        }

        public async Task DeleteAsync(int id)
        {
            var elementToUpdate = await _inventory.GetAsync(id);
            if (elementToUpdate != null)
            {
                await _inventory.DeleteAsync(id);

            }
            

        }

        #region
        public TagsBaseModel Convert(InventoryTagsViewTagsBaseModel ObjectToConvert)
        {
            return new TagsBaseModel()
            {
                Color = ObjectToConvert.TagsColor,
                Id = ObjectToConvert.TagsId,
                Details = ObjectToConvert.TagsDetails,

            };
        }

        #endregion

    }
}

