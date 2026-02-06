using DevOpsBygController.Controllers;

namespace DevOpsBygControllerTests
{
    public class InventoryControllerTest
    {
        private InventoryController _SUT; 

        public InventoryControllerTest() { 
            _SUT = new InventoryController(null);
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
        [InlineData(1,"brk123",-1,":)",false)]
        [InlineData(1,"brk234",0,":)",true)]

        public void GivenQuantityIsNotAnExpectedValueThenFail(int id, string description, int quantity, string image,bool expected)
        {
            //arrange


            //act
            var result = _SUT.GetAll;

            //assert
            Assert.NotNull(result);

        }

    }
}
