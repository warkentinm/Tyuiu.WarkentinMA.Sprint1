using Tyuiu.WarkentinMA.Sprint1.Task2.V8.Lib;

namespace Tyuiu.WarkentinMA.Sprint1.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 5;
            var res = ds.CalculatePerimetr(x, y);
            Assert.AreEqual(16, res);
        }
    }
}
