using BygDevOpsData.Models;
using BygDevOpsData.tagsRepository;
using BygModels.inventory;
using BygModels.inventory.model;
using BygModels.tags;
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
        private ITagsRepository _tagsRepository;
        public InventoryManager(IInventoryRepository inventory, ITagsRepository tags) { 
            _inventory = inventory;
            _tagsRepository = tags;
            
            
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

        /// <summary>
        /// primero va y busca si existe ese elemento a actualizar
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<InventoryBaseModel> UpdateAsync(int id, InventoryBaseModel model)
        {
            
            var elementToUpdate = await _inventory.GetAsync(id);
            if (elementToUpdate != null)
            {

                var arregloTags = model.Tags;
                foreach(var tag in arregloTags)
                {

                    var TagsExists = await _tagsRepository.IsExistsAsync(tag.Details);
                    if ( !TagsExists)
                    {
                        await _tagsRepository.InsertTagsAsync(tag.Details, tag.Icon, tag.Color);
                    }
                
                }

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
                Icon = ObjectToConvert.TagsIcons

            };
        }

        #endregion

    }
}

