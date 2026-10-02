using Tyuiu.WarkentinMA.Sprint1.Task4.V19.Lib;

namespace Tyuiu.WarkentinMA.Sprint1.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 6;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(5, res);

        }
    }
}
