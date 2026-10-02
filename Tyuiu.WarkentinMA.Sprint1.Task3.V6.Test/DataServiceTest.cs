using Tyuiu.WarkentinMA.Sprint1.Task3.V6.Lib;

namespace Tyuiu.WarkentinMA.Sprint1.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 67;
            double y = 8.5;
            double z = 6.5;
            var res = ds.TravelCost(x, y, z);
            Assert.AreEqual(74.04, res);
        }
    }
}
