using DevOpsBygController.Controllers;

namespace DevOpsBygControllerTests
{
    public class InventoryControllerTest
    {
        [Fact]
        public void GetAllAlwaysReturnSucces()
        {
            //arrange
            InventoryController inventoryController = new InventoryController(null);

            //act
            var result = inventoryController.GetAll();

            //assert
            Assert.NotNull(result);

        }
    }
}
