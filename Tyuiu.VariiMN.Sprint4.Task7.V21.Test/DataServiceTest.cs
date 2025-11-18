using System.Data;
using System.Data.Common;
using Tyuiu.VariiMN.Sprint4.Task7.V21.Lib;

namespace Tyuiu.VariiMN.Sprint4.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 4;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "425963128528";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 32;
            Assert.AreEqual(res, wait);
        }
    }
}
