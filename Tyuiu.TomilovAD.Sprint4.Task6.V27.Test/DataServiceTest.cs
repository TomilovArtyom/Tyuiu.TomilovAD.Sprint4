using Tyuiu.TomilovAD.Sprint4.Task6.V27.Lib;

namespace Tyuiu.TomilovAD.Sprint4.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            String[] array = ["Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник"];
            int wait = 1;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
