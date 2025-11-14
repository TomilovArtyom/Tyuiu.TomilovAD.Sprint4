using Tyuiu.TomilovAD.Sprint4.Task4.V7.Lib;

namespace Tyuiu.TomilovAD.Sprint4.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] a = new int[5, 5] { { 4, 3, 6, 5, 5 }, { 3, 4, 4, 6, 4 }, { 6, 4, 6, 4, 5 }, { 5, 4, 4, 4, 5 }, { 3, 5, 6, 4, 6 } };

            int res = ds.Calculate(a);
            int wait = 39;
            Assert.AreEqual(wait, res);
        }
    }
}
