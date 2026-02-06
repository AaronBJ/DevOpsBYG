using BygDevOpsManager.inventory;
using BygModels.inventory;
using BygModels.inventory.model;
using Moq;

namespace BygDevOpsManagerTests
{
    public class BygDevOpsManagerTest
    {
        private Mock<IInventoryRepository> _MockRepository;
        private IInventoryManager _SUT;

        public BygDevOpsManagerTest()
        {
            _MockRepository = new Mock<IInventoryRepository>();
            _SUT = new InventoryManager(_MockRepository.Object);
        }

        [Fact]
        public void GetAllAlwaysReturnSucces()
        {
            //arrange


            //act
            var result = _SUT.GetAllAsync();

            //assert
            Assert.NotNull(result);

        }

        [Theory]
        [InlineData(1, "brk123", -1, ":)")]
        [InlineData(1, "brk234", 0, ":)")]

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
            _MockRepository.Setup(x => x.GetAllAsync()).ReturnsAsync(list);


            //act
            var result = await _SUT.GetAllAsync();

            //assert

            Assert.NotNull(result);

        }


    }
}
