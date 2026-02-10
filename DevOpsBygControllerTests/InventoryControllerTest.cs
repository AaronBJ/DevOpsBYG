using BygModels.inventory;
using BygModels.inventory.model;
using DevOpsBygController.Controllers;
using Moq;
using System.Threading.Tasks;

namespace DevOpsBygControllerTests
{
    public class InventoryControllerTest
    {
        private Mock<IInventoryManager> _MockManager;
        private InventoryController _SUT; 

        public InventoryControllerTest() { 
            _MockManager = new Mock<IInventoryManager>();
            _SUT = new InventoryController(_MockManager.Object);
        }

        [Fact]
        public void GetAllAlwaysReturnSucces()
        {
            //arrange
            

            //act
            var result = _SUT.GetAll();

            //assert
            Assert.NotNull(result);

        }

        [Theory]
        [InlineData(1,"brk123",-1,":)")]
        [InlineData(1,"brk234",0,":)")]

        public async Task GivenQuantityIsNotAnExpectedValueThenFail(int id, string description, int quantity, string image)
        {
            //arrange
            var list = new List<InventoryBaseModel>();
            list.Add(new InventoryBaseModel()
            {
                Id = id,
                Description = description,
                Quantity = quantity,
                Image = image
            });
            _MockManager.Setup(x => x.GetAllAsync()).ReturnsAsync(list);


            //act
            var result = await _SUT.GetAll();

            //assert
            
            Assert.NotNull(result);



        }

    }
}
