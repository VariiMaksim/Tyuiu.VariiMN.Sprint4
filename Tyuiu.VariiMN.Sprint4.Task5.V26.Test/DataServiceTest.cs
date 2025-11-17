using Tyuiu.VariiMN.Sprint4.Task5.V26.Lib;

namespace Tyuiu.VariiMN.Sprint4.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -2, -1, -1, 3, 3 },
                                          { -3, -4, 4, -2, 4 },
                                          { 1, 2, 4, 1, -2 },
                                          { 1, -4, 2, -2, -1 },
                                          { 4, 2, -3, 0, -1 } };
            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5] { { -2, -1, -1, 1, 1 },
                                          { -3, -4, 1, -2, 1 },
                                          { 1, 1, 1, 1, -2 },
                                          { 1, -4, 1, -2, -1 },
                                          { 1, 1, -3, 0, -1 } };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(wait[i, j], res[i, j]);
                }
            }
        }
    }

}
