using BygDevOpsManager.inventory;
using BygModels.inventory;

namespace DevOpsBygController.services
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this ServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IInventoryManager, InventoryManager>();
        }
    }
}
