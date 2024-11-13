using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestingActivitats
{
    [TestClass]
    public class ActivitiesShouldBe
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
            Activitats.Activitats.IsInRange(x, out flag);

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
            Activitats.Activitats.IsInRange(x, out flag);

            //Assert
            Assert.IsFalse(flag);
        }

        [TestMethod]
        [DataRow("A", "a")]
        public void SwapCharUpperLowerCaseTest(string s, string exp)
        {
            //Arrange & Act
            string result = Activitats.Activitats.SwapStringUpperLowerCase(s);

            //Assert
            Assert.Equals(exp, result);
        }
    }
}