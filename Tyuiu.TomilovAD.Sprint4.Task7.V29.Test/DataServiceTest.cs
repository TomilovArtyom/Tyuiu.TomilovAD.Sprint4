using Tyuiu.TomilovAD.Sprint4.Task7.V29.Lib;

namespace Tyuiu.TomilovAD.Sprint4.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "983157642891";
            int rows = 3;
            int columns = 4;
            int[,] matrix = new int[rows, columns];

            int res = ds.Calculate(rows, columns, str);
            int wait = 28;
            Assert.AreEqual(wait, res);
        }
    }
}
