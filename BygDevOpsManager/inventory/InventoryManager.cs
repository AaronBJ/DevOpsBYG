using BygModels.inventory.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BygDevOpsManager.inventory
{
    public class InventoryManager : IInventoryManager
    {
        public async Task<IEnumerable<InventoryBaseModel>> GetAll()
        {
            var lista = new List<InventoryBaseModel>();

            for (var x = 1; x < 10; x++)
            {
                lista.Add(new InventoryBaseModel()
                {

                    Id = x,
                    Description = "BRK 45" + x,
                    Quantity = x + 1,
                    Image = "un texto"


                });
            }
            return lista;
        }
    }
}

