using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestingActivitats
{
    [TestClass]
    public class Ex2ShouldBe
    {
        [TestMethod]
        [DataRow(2)]
        [DataRow(10)]
        [DataRow(22)]
        public void InRangeTrue(int x)
        {
            //Arrange [2,22](^-^)
            bool flag;
            //Act
            Ex2Cool.Program.IsInRange(x, out flag);

            //Assert
            Assert.IsTrue(flag);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(99)]
        public void InRangeFalse(int x)
        {
            //Arrange ]2, 22[
            bool flag;
            //Act
            Ex2Cool.Program.IsInRange(x, out flag);

            //Assert
            Assert.IsFalse(flag);
        }
    }
}54