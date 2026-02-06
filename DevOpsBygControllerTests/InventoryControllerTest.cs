using DevOpsBygController.Controllers;

namespace DevOpsBygControllerTests
{
    public class InventoryControllerTest
    {
        public InventoryControllerTest() { 
            InventoryController SUT = new InventoryController(null);
        }

        [Fact]
        public void GetAllAlwaysReturnSucces()
        {
            //arrange
            

            //act
            var result = SUT.GetAll();

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
            var result = SUT.GetAll;

            //assert
            Assert.NotNull(result);

        }



    }
}
