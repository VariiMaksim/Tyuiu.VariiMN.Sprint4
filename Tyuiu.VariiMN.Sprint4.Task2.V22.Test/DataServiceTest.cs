using Tyuiu.VariiMN.Sprint4.Task2.V22.Lib;

namespace Tyuiu.VariiMN.Sprint4.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 2, 2, 1, 5, 4, 3, 2, 3, 6, 4, 2, 3 };

            int res = ds.Calculate(numsArray);
            int wait = 16;
            Assert.AreEqual(wait, res);
        }
    }
}
