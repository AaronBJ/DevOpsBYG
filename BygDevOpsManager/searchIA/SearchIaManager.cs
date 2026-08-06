using BygModels.enums;
using BygModels.inventory;
using BygModels.searchIa;
using BygModels.searchIa.model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BygDevOpsManager.searchIA
{
    public class SearchIaManager : ISearchIaManager
    {
        private IInventoryRepository _inventoryRepository;

        public SearchIaManager(IInventoryRepository inventoryRepository) { 
           _inventoryRepository = inventoryRepository;
        
        }

        public async Task<IEnumerable<SearchIaBaseModel>> GetSearchAsync()
        {
            var result = new List<SearchIaBaseModel>();

            //aqui se rellena la parte de los inventarios solamente

            var ListaDeInventarios = await _inventoryRepository.GetAllAsync();

            var InventariosIa = ListaDeInventarios.Select(inventory => new SearchIaBaseModel()
            {
                Title = inventory.InventoryDetails,
                Image = inventory.InventoryImage,
                Category = CategoryAreasEnum.Inventory,
                CategoryColor = "#C0C0C0",
                Link = "/inventarioEditar?id=" + inventory.InventoryId


            });


           

            //aqui se rellena la parte de... para futuro

            result.AddRange(InventariosIa);

            return result;

        }
    }
}