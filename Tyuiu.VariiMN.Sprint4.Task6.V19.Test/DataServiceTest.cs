using Tyuiu.VariiMN.Sprint4.Task6.V19.Lib;

namespace Tyuiu.VariiMN.Sprint4.Task6.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var week = new string[] { "Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave" };
            int res = ds.Calculate(week);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
