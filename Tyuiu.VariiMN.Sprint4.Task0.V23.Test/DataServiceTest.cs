using Tyuiu.VariiMN.Sprint4.Task0.V23.Lib;

namespace Tyuiu.VariiMN.Sprint4.Task0.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            int res = ds.GetMultOddArrEl(numsArray);
            int sum = 99225;
            Assert.AreEqual(sum, res);
        }
    }
}
